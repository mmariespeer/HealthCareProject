using System;
using System.Windows.Forms;
using HealthCare.Controller;

namespace HealthCare.View
{
    public partial class AdminDashboard : Form
    {
        private LoginForm lf;
        private readonly HealthcareController healthController;
        public int SelectedNurseID { get; set; }

        public AdminDashboard(LoginForm lf)
        {
            InitializeComponent();
            this.healthController = new HealthcareController();
            this.lf = lf;
            this.SelectedNurseID = 0;
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
        /// Reload the tabs when a nurse is selected
        /// </summary>
        /// <param name="sender">as an object</param>
        /// <param name="e">event argument</param>
        public void RefreshTabs(object sender, EventArgs e)
        {
            this.viewNurseUserControl1.ViewNurseUserControl_Load(sender, e);
        }

        private void logoutLinkDashboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            lf.Show();
        }

        private void AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
