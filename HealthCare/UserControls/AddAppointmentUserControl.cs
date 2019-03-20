using System;
using System.Collections.Generic;
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

        public AddAppointmentUserControl()
        {
            InitializeComponent();
            healthcareController = new HealthcareController();
            this.LoadDoctorComboBox();
        }

        // Manages the information obtained from the database that populates the comboboxes
        public void LoadDoctorComboBox()
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
            MessageBox.Show(appointment.DoctorID + "");
            appointment.DateTime = appointmentDateTimePicker.Value;
            appointment.ReasonForVisit = reasonForVisitTextBox.Text;
        }
    }
}
