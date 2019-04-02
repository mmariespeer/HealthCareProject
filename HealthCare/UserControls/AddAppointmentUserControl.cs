using System;
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

        public AddAppointmentUserControl()
        {
            InitializeComponent();
            time = DateTime.Today;
            healthcareController = new HealthcareController();
            this.LoadDoctorComboBox();
            this.LoadTimesComboBox();
            this.patientID = 0;
        }

        // Manages the information obtained from the database that populates the comboboxes
        private void LoadDoctorComboBox()
        {
            try
            {
                List<Doctor> doctorForAppointments = healthcareController.GetDoctors();

                List<Person> doctorNames = new List<Person>();
                foreach (Doctor doc in doctorForAppointments)
                {
                    doctorNames.Add(this.healthcareController.GetPeronById(doc.PersonID));
                }
                doctorComboBox.DataSource = doctorNames;
                doctorComboBox.DisplayMember = "FullName";
                doctorComboBox.ValueMember = "personID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        //Creates a combobox of times between 9:00am and 4:30pm for a nurse to use in scheduling
        private void LoadTimesComboBox()
        {
            selectedTime = new DataTable();
            selectedTime.Columns.Add("dateTime", typeof(DateTime));
            selectedTime.Columns.Add("time", typeof(string));
            try
            {
                for (DateTime tm = time.AddHours(9); tm < time.AddHours(17); tm = tm.AddMinutes(30))
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

        //Creates a new appointment on button click
        private void createAppointmentButton_Click(object sender, EventArgs e)
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
        
        //Reads the data inputed into the fields and inserts into the new appointment
        private void ReadIncidentData(Appointment appointment)
        {
            appointment.PatientID = this.patientID;

            int docID = (int)doctorComboBox.SelectedValue;
            appointment.DoctorID = this.healthcareController.GetDoctorByPersonID(docID).DoctorID;

            DateTime appointmentTime = (DateTime)appointmentTimeComboBox.SelectedValue;
            appointment.DateTime = appointmentDateTimePicker.Value.Date + appointmentTime.TimeOfDay;

            appointment.ReasonForVisit = reasonForVisitTextBox.Text;
        }

        //Clears all data from appointment 
        private void ClearScheduling()
        {
            this.LoadDoctorComboBox();
            this.LoadTimesComboBox();
            reasonForVisitTextBox.Text = "";
            this.LoadAppointmentGridView();
        }

        //Populates the appointment gridview with the selected patients appointment information
        private void LoadAppointmentGridView()
        {
            List<Appointment> appointments = new List<Appointment>();
            appointmentGridView.DataBindings.Clear();
            appointments = this.healthcareController.GetAppointmentsByPatientID(this.patientID);
            appointmentGridView.DataSource = appointments;
        }

        //Updates the gridview when there are multiple patients to choose from
        private void patientGridView_SelectionChanged(object sender, EventArgs e)
        {
            this.LoadAppointmentGridView();
        }

        //Loads the scheduled appointments for the current patient ID
        public void AddAppointmentUserControl_Load(object sender, EventArgs e)
        {
            try
            {
                NurseDashboard dashboard = this.ParentForm as NurseDashboard;
                this.patientID = dashboard.SelectedPatientID;

                

                if (this.patientID != 0)
                {
                    this.LoadAppointmentGridView();
                    this.createAppointmentButton.Enabled = true;
                    this.doctorComboBox.Enabled = true;
                    this.appointmentDateTimePicker.Enabled = true;
                    this.appointmentTimeComboBox.Enabled = true;
                }
                else
                {
                    this.ClearScheduling();
                    this.createAppointmentButton.Enabled = false;
                    this.doctorComboBox.Enabled = false;
                    this.appointmentDateTimePicker.Enabled = false;
                    this.appointmentTimeComboBox.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }
    }
}
