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

        public void RefreshTabs(object sender, EventArgs e)
        {
            Debug.WriteLine("called");
            this.visitUserControl1.VisitUserControl_Load(sender, e);
        }

        private void logoutLinkDashboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            lf.Show();
        }

    }
}
