using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HealthCare.Controller;
using HealthCare.Model;

namespace HealthCare.UserControls
{
    public partial class PatientSearchUserControl : UserControl
    {
        private readonly HealthcareController healthController;
        private List<Patient> patientList;
        private List<SearchPatient> searchList;


        public PatientSearchUserControl()
        {
            InitializeComponent();
            this.healthController = new HealthcareController();

        }

        private void PatientSearchUserControl_Load(object sender, EventArgs e)
        {
            try
            {
                patientList = this.healthController.GetAllPatients();

               fullNameComboBox.DataSource = patientList;
               fullNameComboBox.SelectedIndex = 0;

                searchList = this.healthController.GetSelectedPatients(patientList[0].PersonID);
                searchPatientDataGridView.DataSource = searchList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fullNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fullNameComboBox.SelectedIndex < 0) 
            {
                return;
            }

            Patient patient = patientList[fullNameComboBox.SelectedIndex];
           patientBindingSource.Clear();
          patientBindingSource.Add(patient);

            try
            {
              searchList = this.healthController.GetSelectedPatients(patient.PersonID);
              searchPatientDataGridView.DataSource = searchList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DOBButton_Click(object sender, EventArgs e)
        {

            foreach (Patient patient in patientList)
            {
                if (patient.DateOfBirth.ToString("M/d/yyyy") == DOBTextBox.Text)
                {
                    patientBindingSource.Clear();
                    patientBindingSource.Add(patient);

                    try
                    {
                        searchList = this.healthController.GetPatientsByDOB(patient.DateOfBirth);
                        Console.WriteLine("here2");
                        searchPatientDataGridView.DataSource = searchList;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    return;
                }
            }

         
        }

        private void lastNameButton_Click(object sender, EventArgs e)
        {
            foreach (Patient patient in patientList)
            {
                if (patient.LastName == lastNameTextBox.Text)
                {

                   patientBindingSource.Clear();
                   patientBindingSource.Add(patient);

                    try
                    {
                        searchList = this.healthController.GetPatientsByLastName(patient.LastName);
                        searchPatientDataGridView.DataSource = searchList;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    return;
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.DOBTextBox.Text = "";
            this.lastNameTextBox.Text = "";
        }
    }
    }

