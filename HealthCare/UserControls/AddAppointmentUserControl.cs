using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HealthCare.Controller;
using HealthCare.Model;

namespace HealthCare.UserControls
{
    public partial class AddAppointmentUserControl : UserControl
    {
        private HealthcareController healthcareController;
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
    }
}
