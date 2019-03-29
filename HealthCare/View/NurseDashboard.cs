using System;
using System.Diagnostics;
using System.Windows.Forms;
using HealthCare.Controller;

namespace HealthCare.View
{
    public partial class NurseDashboard : Form
    {
        private LoginForm lf;
        private readonly HealthcareController healthController;
        public int SelectedPatientID { get; set; }

        public NurseDashboard(LoginForm lf)
        {
            InitializeComponent();
            this.healthController = new HealthcareController();
            this.lf = lf;
            this.SelectedPatientID = 0;
        }

        /// <summary>
        /// set the text for nameLabel
        /// </summary>
        /// <param name="myText"></param>
        public void SetTextForLabel(string myText)
        {
            this.nameLabel.Text = myText;
        }

        /// <summary>
        /// Reload the tabs when a patient is selected
        /// </summary>
        /// <param name="sender">as an object</param>
        /// <param name="e">event argument</param>
        public void RefreshTabs(object sender, EventArgs e)
        {
            this.visitUserControl1.VisitUserControl_Load(sender, e);
        }

        private void LogoutLinkDashboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            lf.Show();
        }

        private void NurseDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
