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
        private List<SearchPatient> patients;

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
            appointment.PatientID = this.GetPatientIDBySelectedRow();

            int docID = (int)doctorComboBox.SelectedValue;
            appointment.DoctorID = this.healthcareController.GetDoctorByPersonID(docID).DoctorID;

            DateTime appointmentTime = (DateTime)appointmentTimeComboBox.SelectedValue;
            appointment.DateTime = appointmentDateTimePicker.Value.Date + appointmentTime.TimeOfDay;

            appointment.ReasonForVisit = reasonForVisitTextBox.Text;
        }

        //Reads the selected row and returns a patient ID based off row data
        private int GetPatientIDBySelectedRow()
        {
            int rowindex = patientGridView.CurrentCell.RowIndex;
            int columnindex = patientGridView.CurrentCell.ColumnIndex;

            int patientID = Convert.ToInt32(patientGridView.Rows[rowindex].Cells[columnindex].Value.ToString());
            return patientID;
        }

        private void ClearScheduling()
        {
            this.LoadDoctorComboBox();
            this.LoadTimesComboBox();
            reasonForVisitTextBox.Text = "";
        }

        //Searches for patient by last name when button is clicked.
        private void searchByLastNameButton_Click(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text == null || lastNameTextBox.Text == "")
            {
                MessageBox.Show("Please enter last name.");
                return;
            }
            try
            {
                patientGridView.DataBindings.Clear();
                patients = this.healthcareController.GetPatientsByLastName(lastNameTextBox.Text);
                if (!patients.Any())
                {
                    MessageBox.Show("No patients with that last name.");
                    return;
                }
                patientGridView.DataSource = patients;
                this.LoadAppointmentGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        //Searches for patient by date of birth when the search button is clicked.
        private void searchDOBButton_Click(object sender, EventArgs e)
        {
            if(dobPicker.Value.Date == DateTime.Now.Date)
            {
                MessageBox.Show("Please select a Date of Birth");
                return;
            }

            try
            {
                patientGridView.DataBindings.Clear();
                patients = this.healthcareController.GetPatientsByDOB(dobPicker.Value.Date);
                if (!patients.Any())
                {
                    MessageBox.Show("No patients with that date of birth.");
                    return;
                }
                patientGridView.DataSource = patients;
                this.LoadAppointmentGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error has occured. " + ex.Message);
            }
        }

        //Populates the appointment gridview with the selected patients appointment information
        private void LoadAppointmentGridView()
        {
            List<Appointment> appointments = new List<Appointment>();
            appointmentGridView.DataBindings.Clear();
            appointments = this.healthcareController.GetAppointmentsByPatientID(this.GetPatientIDBySelectedRow());
            appointmentGridView.DataSource = appointments;
        }

        //Updates the gridview when there are multiple patients to choose from
        private void patientGridView_SelectionChanged(object sender, EventArgs e)
        {
            this.LoadAppointmentGridView();
        }
    }
}
