using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HealthCare.Controller;
using HealthCare.Model;
using HealthCare.View;

namespace HealthCare.UserControls
{
    public partial class VisitUserControl : UserControl
    {
        private int patientID;
        private HealthcareController controller;

        public VisitUserControl()
        {
            InitializeComponent();
            this.controller = new HealthcareController();
            this.patientID = 0;
        }

        public void VisitUserControl_Load(object sender, EventArgs e)
        {
            NurseDashboard dashboard = this.ParentForm as NurseDashboard;
            this.patientID = dashboard.SelectedPatientID;

            if (this.patientID != 0)
            {
                this.PopulateApptList();
            }

        }

        private void PopulateApptList()
        {
            List<Appointment> apptList = new List<Appointment>();
            apptList = this.controller.GetAppointmentsByPatientID(this.patientID);
            this.visitListView.Items.Clear();
            this.visitListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            if (apptList.Count > 0)
            {
                Appointment appt;
                for (int i = 0; i < apptList.Count; i++)
                {
                    appt = apptList[i];
                    this.visitListView.Items.Add(appt.AppointmentID.ToString());
                    this.visitListView.Items[i].SubItems.Add(appt.DateTime.ToShortDateString());
                }
                this.visitListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                this.visitListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

            }
            else
            {
                MessageBox.Show("There are no patients that meet your search criteria!" +
                                Environment.NewLine, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VisitListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int apptID = int.Parse(this.visitListView.SelectedItems[0].SubItems[0].Text);
            this.visitListView.Enabled = false;
            Visit visit = this.controller.GetVisitByAppointmentID(apptID);
            this.doctorTextBox.Text = visit.DoctorName.ToString();
            this.weightTextBox.Text = visit.Weight.ToString();
            this.tempTextBox.Text = visit.Temp.ToString();
            this.systolicTextBox.Text = visit.SystolicBP.ToString();
            this.diastolicTextBox.Text = visit.DiastolicBP.ToString();
            this.symptomsTextBox.Text = visit.Symptoms;
            this.initDiagnosisTextBox.Text = visit.InitialDiagnosis;
            this.finalDiagnosisTextBox.Text = visit.FinalDiagnosis;

        }
    }
}
