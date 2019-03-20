using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using HealthCare.Controller;
using HealthCare.Model;

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

        public AddAppointmentUserControl()
        {
            InitializeComponent();
            time = DateTime.Today;
            healthcareController = new HealthcareController();
            this.LoadDoctorComboBox();
            this.LoadTimesComboBox();
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
           try
            {
                this.healthcareController.AddAppointment(appointment);
                appointmentCreatedLabel.Text = "Your appointment has been created!";
           }
            catch (Exception)
            {
               MessageBox.Show("Your appointment has not been added.");
            }
        }
        
        //Reads the data inputed into the fields and inserts into the new appointment
        private void ReadIncidentData(Appointment appointment)
        {
            
            appointment.PatientID = 1;
            
            int docID = (int)doctorComboBox.SelectedValue;
            appointment.DoctorID = this.healthcareController.GetDoctorByPersonID(docID).DoctorID;

            DateTime appointmentTime = (DateTime)appointmentTimeComboBox.SelectedValue;
            appointment.DateTime = appointmentDateTimePicker.Value.Date + appointmentTime.TimeOfDay;
            appointment.ReasonForVisit = reasonForVisitTextBox.Text;
        }
    }
}
