using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HealthCare.Controller;
using HealthCare.Model;
using HealthCare.View;

namespace HealthCare.UserControls
{
    /// <summary>
    /// User control to display patient visit information
    /// </summary>
    public partial class VisitUserControl : UserControl
    {
        private AddTestForm addTest;
        private LogTestResultForm logTest;
        private int patientID;
        private HealthcareController controller;
        private int _visitID;

        /// <summary>
        /// Initalizes controller and patientID to 0
        /// </summary>
        public VisitUserControl()
        {
            InitializeComponent();
            this.controller = new HealthcareController();
            this.patientID = 0;
            
        }

        /// <summary>
        /// Loads the appointment list by the SelectedPatientID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void VisitUserControl_Load(object sender, EventArgs e)
        {
            
            try
            {
                NurseDashboard dashboard = this.ParentForm as NurseDashboard;
                this.patientID = dashboard.SelectedPatientID;

                //This is going to be implemented later
                this.addTestsButton.Enabled = false;

                if (this.patientID != 0)
                {
                    this.ResetVisitForm();
                    this.PopulateApptList();
                    this.visitListView.Enabled = true;
                    this.updateButton.Enabled = true;
                }
                else
                {
                    this.ResetVisitForm();
                }
            } 
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Clears all data from visit information
        /// </summary>
        private void ResetVisitForm()
        {
            this.doctorTextBox.Text = "";
            this.weightTextBox.Text = "";
            this.tempTextBox.Text = "";
            this.systolicTextBox.Text = "";
            this.diastolicTextBox.Text = "";
            this.symptomsTextBox.Text = "";
            this.initDiagnosisTextBox.Text = "";
            this.finalDiagnosisTextBox.Text = "";
            this.updateButton.Enabled = false;
            this.testsListView.Items.Clear();
            this.visitListView.Items.Clear();
        }

        /// <summary>
        /// Populates the appointment list for a specific patient
        /// </summary>
        private void PopulateApptList()
        {
            List<Appointment> apptList = new List<Appointment>();
            apptList = this.controller.GetAppointmentsByPatientID(this.patientID);
            this.visitListView.Items.Clear();

            if (apptList.Count > 0)
            {
                Appointment appt;
                for (int i = 0; i < apptList.Count; i++)
                {
                    appt = apptList[i];
                    this.visitListView.Items.Add(appt.AppointmentID.ToString());
                    this.visitListView.Items[i].SubItems.Add(appt.DateTime.ToShortDateString());
                }

            }
            else
            {
                MessageBox.Show("The selected patient does not have an scheduled appointments." +
                                Environment.NewLine, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// On visit selection change, displays appropriate information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VisitListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int apptID = int.Parse(this.visitListView.SelectedItems[0].SubItems[0].Text);
            this.visitListView.Enabled = false;
            Visit visit = this.controller.GetVisitByAppointmentID(apptID);
            _visitID = visit.VisitID;
            if (visit.VisitID != 0)
            {
                this.doctorTextBox.Text = visit.DoctorName.ToString();
                this.weightTextBox.Text = visit.Weight.ToString();
                this.tempTextBox.Text = visit.Temp.ToString(); 
                this.systolicTextBox.Text = visit.SystolicBP.ToString();
                this.diastolicTextBox.Text = visit.DiastolicBP.ToString();
                this.symptomsTextBox.Text = visit.Symptoms;
                this.initDiagnosisTextBox.Text = visit.InitialDiagnosis;
                this.finalDiagnosisTextBox.Text = visit.FinalDiagnosis;
                this.GetTests(visit.VisitID);
                this.addTestsButton.Enabled = true;
                this.addTest = new AddTestForm(visit.VisitID, this);
            } else
            {
                this.doctorTextBox.Text = visit.DoctorName.ToString();
                this.weightTextBox.Text = "";
                this.tempTextBox.Text = "";
                this.systolicTextBox.Text = "";
                this.diastolicTextBox.Text = "";
                this.symptomsTextBox.Text = "";
                this.initDiagnosisTextBox.Text = "";
                this.finalDiagnosisTextBox.Text = "";
            }            
        }

        /// <summary>
        /// Gets all tests for a specific visit
        /// </summary>
        /// <param name="visitId">visitID to search</param>
        private void GetTests(int visitId)
        {
            List<Test> testList = new List<Test>();
            testList = this.controller.GetTestsByVisitId(visitId);

            this.testsListView.Items.Clear();

            if (testList.Count > 0)
            {
                Test test;
                for (int i = 0; i < testList.Count; i++)
                {
                    test = testList[i];
                    this.testsListView.Items.Add(test.TestCode.ToString());
                    this.testsListView.Items[i].SubItems.Add(test.TestName);
                    this.testsListView.Items[i].SubItems.Add(test.TestDate.ToShortDateString());
                    this.testsListView.Items[i].SubItems.Add(test.Results);
                    this.testsListView.Items[i].SubItems.Add(test.Normal.ToString());
                }
            }
        }

        /// <summary>
        /// On click, updates the visit information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            bool validDiastolic = int.TryParse(this.diastolicTextBox.Text, out int diastolicValidated);
            if (!validDiastolic)
            {
                MessageBox.Show("Diastolic BP is required, it must be a integer and cannot be empty!" + Environment.NewLine,
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool validSystolic = int.TryParse(this.systolicTextBox.Text, out int systolicValidated);
            if (!validSystolic)
            {
                MessageBox.Show("Systolic BP is required, it must be a integer and cannot be empty!" + Environment.NewLine,
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool validTemp = decimal.TryParse(this.tempTextBox.Text, out decimal tempValidated);
            if (!validTemp)
            {
                MessageBox.Show("Temperature is required, it must be a number and cannot be empty!" + Environment.NewLine,
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool validWeight = decimal.TryParse(this.weightTextBox.Text, out decimal weightValidated);
            if (!validWeight)
            {
                MessageBox.Show("Weight is required and must be greater than zero!" + Environment.NewLine,
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(this.initDiagnosisTextBox.Text) || this.initDiagnosisTextBox.Text.Length >= 50)
            {
                MessageBox.Show("Initial Diagnosis is required, must be less than 50 characters and cannot be empty!" + Environment.NewLine,
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.symptomsTextBox.Text.Length > 250 || string.IsNullOrEmpty(this.symptomsTextBox.Text))
            {
                MessageBox.Show("Initial Diagnosis is required, must be less than 50 characters and cannot be empty!" + Environment.NewLine,
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //PULSE STILL NEEDED
            Visit visit = new Visit()
            {
                DiastolicBP = diastolicValidated,
                SystolicBP = systolicValidated,
                Weight = weightValidated,
                Temp = tempValidated,
                Symptoms = this.symptomsTextBox.Text,
                NurseID = 1,
                AppointmentID = int.Parse(this.visitListView.SelectedItems[0].SubItems[0].Text),
                InitialDiagnosis = this.initDiagnosisTextBox.Text,
                FinalDiagnosis = this.finalDiagnosisTextBox.Text
            };

            bool success = this.controller.AddVisit(visit);

            if (success)
            {
                MessageBox.Show("Patient visit data has been updated!" + Environment.NewLine,
                "Success!", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            else
            {
                MessageBox.Show("Patient visit data has NOT been updated!" + Environment.NewLine,
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void AddTestsButton_Click(object sender, EventArgs e)
        {
            
            this.addTest.ShowDialog();
        }

        private void updateResultButton_Click(object sender, EventArgs e)
        {
            this.logTest.ShowDialog();
        }

        private void testsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.testsListView.SelectedItems.Count > 0)
            {
                string result = this.testsListView.SelectedItems[0].SubItems[3].Text;
                if (!string.IsNullOrEmpty(result))
                {
                    updateResultButton.Enabled = false;
                }
                else
                {
                    string testCode = this.testsListView.SelectedItems[0].SubItems[0].Text;
                    this.logTest = new LogTestResultForm(this._visitID,testCode,this);
                    updateResultButton.Enabled = true;
                }
            }

        }

        private void clearVisitButton_Click(object sender, EventArgs e)
        {
            this.VisitUserControl_Load(sender, e);
        }
    }
}
