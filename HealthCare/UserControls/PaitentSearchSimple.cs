using HealthCare.Controller;
using HealthCare.Model;
using HealthCare.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace HealthCare.UserControls
{
    /// <summary>
    /// Simple search bar for all tabs controls to use from main nurse dashboard
    /// </summary>
    public partial class PaitentSearchSimple : UserControl
    {
        private HealthcareController controller;
        public PaitentSearchSimple()
        {
            InitializeComponent();
            this.controller = new HealthcareController();
        }

        /// <summary>
        /// On click, searches for patient with specific last name and dob, full name, or just dob
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Sets the listview to the patients found
        /// </summary>
        /// <param name="patientList">List of patients found in search</param>
        private void SetListView(List<Patient> patientList)
        {
            this.patientListView.Items.Clear();

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

        /// <summary>
        /// Sets the SelectedPatientID to the current patient selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PatientListView_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(this.patientListView.SelectedItems.Count == 0)
            {
                return;
            }
            NurseDashboard dashboard = this.ParentForm as NurseDashboard;
            dashboard.SelectedPatientID = int.Parse(this.patientListView.SelectedItems[0].SubItems[0].Text);
            dashboard.RefreshTabs(sender, e);
        }

        /// <summary>
        /// Clears all the data from search fields and tabs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.patientListView.Items.Clear();
            this.firstNameTextBox.Text = "";
            this.lastNameTextBox.Text = "";
            NurseDashboard dashboard = this.ParentForm as NurseDashboard;
            dashboard.SelectedPatientID = 0;
            dashboard.RefreshTabs(sender, e);
        }
    }
}