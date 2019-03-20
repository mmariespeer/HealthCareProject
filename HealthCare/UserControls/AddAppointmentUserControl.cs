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
                doctorComboBox.DataSource = doctorForAppointments;
                doctorComboBox.DisplayMember = "personID";
                doctorComboBox.ValueMember = "doctorID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
