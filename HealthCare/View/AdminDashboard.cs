using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthCare.Controller;

namespace HealthCare.View
{
    public partial class AdminDashboard : Form
    {
        private LoginForm lf;
        private readonly HealthcareController healthController;

        public AdminDashboard(LoginForm lf)
        {
            InitializeComponent();
            this.healthController = new HealthcareController();
            this.lf = lf;
        }

        /// <summary>
        /// set the text for nameLabel
        /// </summary>
        /// <param name="myText"></param>
        public void SetTextForLabel(string myText)
        {
            this.nameLabel.Text = myText;
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
