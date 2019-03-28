using HealthCare.Controller;
using HealthCare.Model;
using HealthCare.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;

namespace HealthCare.UserControls
{
    public partial class PaitentSearchSimple : UserControl
    {
        private HealthcareController controller;
        public PaitentSearchSimple()
        {
            InitializeComponent();
            this.controller = new HealthcareController();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            List<Patient> patientList;
            
            //Check for dob presence first
            if (this.dobMaskedTextBox.MaskFull)
            {
                try
                {
                    DateTime dob = DateTime.Parse(this.dobMaskedTextBox.Text);
                    //Check for last name
                    if (!String.IsNullOrEmpty(this.lastNameTextBox.Text))
                    {
                        patientList = this.controller.GetPatientsByDOBandLastName(dob, this.lastNameTextBox.Text);
                        this.SetListView(patientList);
                    }
                    else
                    {
                        patientList = this.controller.GetPatientsByDOB(dob);
                        this.SetListView(patientList);
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid date entered!" +
                    Environment.NewLine, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            //if no dob, check for full name
            else if (!String.IsNullOrEmpty(this.lastNameTextBox.Text) && !String.IsNullOrEmpty(this.firstNameTextBox.Text))
            {
                patientList = this.controller.GetPatientsByFullName(this.firstNameTextBox.Text, this.lastNameTextBox.Text);
                this.SetListView(patientList);
            }
            else
            {
                MessageBox.Show("You must enter either the date of birth, date of birth and last name, or both first and last name for patient search!" +
                Environment.NewLine, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void SetListView(List<Patient> patientList)
        {
            this.patientListView.Items.Clear();
            this.patientListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            if (patientList.Count > 0)
            {
                Patient patient;
                for (int i = 0; i < patientList.Count; i++)
                {
                    patient = patientList[i];
                    this.patientListView.Items.Add(patient.PatientID.ToString());
                    this.patientListView.Items[i].SubItems.Add(patient.LastName.ToString());
                    this.patientListView.Items[i].SubItems.Add(patient.FirstName.ToString());
                    this.patientListView.Items[i].SubItems.Add(patient.DateOfBirth.ToShortDateString());
                   
                }
                this.patientListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                this.patientListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
                this.patientListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
                this.patientListView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);

            } else
            {
                MessageBox.Show("There are no patients that meet your search criteria!" +
                                Environment.NewLine, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PatientListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            NurseDashboard dashboard = this.ParentForm as NurseDashboard;
            dashboard.SelectedPatientID = int.Parse(this.patientListView.SelectedItems[0].SubItems[0].Text);
            dashboard.RefreshTabs(sender, e);
        }
    }
}