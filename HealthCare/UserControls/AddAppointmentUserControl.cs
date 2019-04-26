﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using HealthCare.Controller;
using HealthCare.Model;
using HealthCare.View;

namespace HealthCare.UserControls
{
    /// <summary>
    /// Creates form to add a new appointment
    /// </summary>
    public partial class AddAppointmentUserControl : UserControl
    {
        private HealthcareController healthcareController;
        private Appointment appointment;
        private DateTime time;
        private DataTable selectedTime;
        private int patientID;
        List<Person> doctorNames;
        private int appointmentID;


        /// <summary>
        /// Initalizes appointment user control
        /// </summary>
        public AddAppointmentUserControl()
        {
            InitializeComponent();
            time = DateTime.Today;
            healthcareController = new HealthcareController();
            this.LoadDoctorComboBox();
            this.LoadTimesComboBox();
            this.patientID = 0;
        }

        /// <summary>
        /// Manages the information obtained from the database that populates the comboboxes
        /// </summary>
        private void LoadDoctorComboBox()
        {
            try
            {
                List<Doctor> doctorForAppointments = healthcareController.GetDoctors();

                this.doctorNames = new List<Person>();
                foreach (Doctor doc in doctorForAppointments)
                {
                    this.doctorNames.Add(this.healthcareController.GetPeronById(doc.PersonID));
                }
                doctorComboBox.DataSource = this.doctorNames;
                doctorComboBox.DisplayMember = "FullName";
                doctorComboBox.ValueMember = "personID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Populates the listview of the selected doctors specialites
        /// </summary>
        private void PopulateDoctorSpecialities()
        {
            if(doctorComboBox.ValueMember.ToString() == "" || doctorComboBox.ValueMember.ToString() == null)
            {
                return;
            }
            int personID = Int32.Parse(doctorComboBox.SelectedValue.ToString());
            int doctorID = this.healthcareController.GetDoctorByPersonID(personID).DoctorID;
            
            List<Specialty> specialties = new List<Specialty>();
            specialties = this.healthcareController.GetSpecialtiesByDoctorID(doctorID);

            this.specialtyListView.Items.Clear();

            if (specialties.Count > 0)
            {
                Specialty specialty;
                for (int i = 0; i < specialties.Count; i++)
                {
                   specialty = specialties[i];
                   this.specialtyListView.Items.Add(specialty.SpecialityName.ToString());
                }
            }
        }

        /// <summary>
        /// Creates a combobox of times between 9:00am and 4:30pm for a nurse to use in scheduling
        /// </summary>
        private void LoadTimesComboBox()
        {
            selectedTime = new DataTable();
            selectedTime.Columns.Add("dateTime", typeof(DateTime));
            selectedTime.Columns.Add("time", typeof(string));
            try
            {
                for (DateTime tm = time.AddHours(9); tm < time.AddHours(17); tm = tm.AddMinutes(15))
                {
                    selectedTime.Rows.Add(tm, tm.ToShortTimeString());
                }
                appointmentTimeComboBox.DataSource = selectedTime;
                appointmentTimeComboBox.DisplayMember = "time";
                appointmentTimeComboBox.ValueMember = "dateTime";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        /// <summary>
        /// Creates a new appointment on button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateAppointmentButton_Click(object sender, EventArgs e)
        {
            appointment = new Appointment();
            if (appointment == null)
            {
                throw new ArgumentException("Appointment cannot be null or empty.");
            }
            this.ReadIncidentData(appointment);
            if (this.healthcareController.CheckIfDoctorHasAppointmentScheduled(appointment.DoctorID, appointment.DateTime))
            {
                MessageBox.Show("An appointment has already been scheduled at this time and date with this doctor. " +
                    "Please select another date, time, or doctor.");
                return;
            }
            if (reasonForVisitTextBox.Text == null || reasonForVisitTextBox.Text == "")
            {
                MessageBox.Show("Reason for visit cannot be null or empty.");
                return;
            }
            try
            {
                this.healthcareController.AddAppointment(appointment);
                this.LoadAppointmentGridView();
                this.ClearScheduling();
                MessageBox.Show("Appointment has been created! \n"
                    + this.healthcareController.GetPersonByPatientID(appointment.PatientID).FirstName + " "
                    + this.healthcareController.GetPersonByPatientID(appointment.PatientID).LastName + "\n"
                    + "on " + appointment.DateTime.ToShortDateString() + " at " + appointment.DateTime.ToShortTimeString() + "\n"
                    + "With Dr. " + this.healthcareController.GetPersonByDoctorID(appointment.DoctorID).LastName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }


        /// <summary>
        /// Clears all data from appointment 
        /// </summary>
        private void ClearScheduling()
        {
            //this.LoadDoctorComboBox();
            //this.LoadTimesComboBox();
            this.appointmentTimeComboBox.SelectedIndex = -1;
            //this.doctorComboBox.SelectedIndex = -1;
            reasonForVisitTextBox.Text = "";
            this.LoadAppointmentGridView();
            this.appointmentDateTimePicker.Value = DateTime.Now;
        }

        /// <summary>
        /// Populates the appointment gridview with the selected patients appointment information
        /// </summary>
        private void LoadAppointmentGridView()
        {
        try
            {
                DataTable dt = new DataTable();
                //List<Appointment> appointment = new Appointment();
                //appointment = this.healthcareController.GetAppointmentsByPatientID(this.patientID);
                appointmentGridView.DataBindings.Clear();
                dt = this.healthcareController.GetAppointmentsAndDoctorByPatientID(this.patientID);
                appointmentGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        /// <summary>
        /// Loads the scheduled appointments for the current patient ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AddAppointmentUserControl_Load(object sender, EventArgs e)
        {
            try
            {
                NurseDashboard dashboard = this.ParentForm as NurseDashboard;
                this.patientID = dashboard.SelectedPatientID;

                if (this.patientID != 0)
                {

                    this.LoadAppointmentGridView();
                    this.PopulateAppointment();
                    this.createAppointmentButton.Enabled = true;
                    this.clearButton.Enabled = true;

                    this.doctorComboBox.Enabled = true;
                    this.appointmentDateTimePicker.Enabled = true;
                    this.appointmentTimeComboBox.Enabled = true;
                    this.specialtyListView.Enabled = true;
                }
                else
                {
                    this.ClearScheduling();
                    this.createAppointmentButton.Enabled = false;
                    this.updateAppointmentButton.Enabled = false;
                    this.doctorComboBox.Enabled = false;
                    this.appointmentDateTimePicker.Enabled = false;
                    this.appointmentTimeComboBox.Enabled = false;
                    this.specialtyListView.Enabled = false;
                    this.clearButton.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }

        private void doctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PopulateDoctorSpecialities();
        }

        private void PopulateAppointment()
        {
            try
            {
                Appointment appmt = this.healthcareController.GetAppointmentByAppointmentID(this.appointmentID);
                this.reasonForVisitTextBox.Text = appmt.ReasonForVisit;
                this.doctorComboBox.SelectedIndex = this.doctorComboBox.FindStringExact(appmt.DoctorName);

                this.appointmentDateTimePicker.Value = appmt.DateTime.Date;
                this.appointmentTimeComboBox.SelectedIndex = this.appointmentTimeComboBox.FindStringExact(appmt.DateTime.ToString("h:mm tt"));

                if (appmt.DateTime <= DateTime.Now.Date)
                {
                    this.updateAppointmentButton.Enabled = false;
                    this.updateLabel.Visible = true;
                }
                else
                {
                    this.updateAppointmentButton.Enabled = true;
                    this.updateLabel.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        /// <summary>
        /// Reads the data inputed into the fields and inserts into the new appointment
        /// </summary>
        /// <param name="appointment"></param>
        private void ReadIncidentData(Appointment appointment)
        {

            appointment.PatientID = this.patientID;

            int docID = (int)doctorComboBox.SelectedValue;
            appointment.DoctorID = this.healthcareController.GetDoctorByPersonID(docID).DoctorID;

            DateTime appointmentTime = (DateTime)appointmentTimeComboBox.SelectedValue;
            appointment.DateTime = appointmentDateTimePicker.Value.Date + appointmentTime.TimeOfDay;

            appointment.ReasonForVisit = reasonForVisitTextBox.Text;


        }

        private void updateAppointmentButton_Click(object sender, EventArgs e)
        {
            if (reasonForVisitTextBox.Text == null || reasonForVisitTextBox.Text == "" ||
                this.appointmentDateTimePicker.Value == null || this.appointmentTimeComboBox.SelectedIndex == -1 || this.doctorComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("All fields must be filled in.", "Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                appointment = new Appointment();
                this.ReadIncidentData(appointment);
                appointment.AppointmentID = this.appointmentID;

                try
                {
                    this.healthcareController.UpdateAppointment(appointment);
                    MessageBox.Show("Appointment has been updated");
                    this.LoadAppointmentGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void appointmentGridView_SelectionChanged(object sender, EventArgs e)
        {
        if (this.appointmentGridView.Rows.Count != 0)
            {

                foreach (DataGridViewRow row in this.appointmentGridView.SelectedRows)
                {
                    this.appointmentID = (int)row.Cells[0].Value;
                }

                this.PopulateAppointment();
            }
        else
            {
                this.appointmentGridView.ClearSelection();
                this.ClearScheduling();
            }
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.AddAppointmentUserControl_Load(sender, e);
            this.ClearScheduling();
            this.appointmentGridView.ClearSelection();
        }
    }
}




