using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using HealthCare.Controller;

namespace HealthCare.View
{
    public partial class LoginForm : Form
    {
       private NurseDashboard nd;
      //private AdminDashboard ad;
        private readonly HealthcareController healthController;


        public LoginForm()
        {
            InitializeComponent();
            this.healthController = new HealthcareController();
            nd = new NurseDashboard(this);
           //ad = new NurseDashboard(this);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            DataTable dt = this.healthController.getLogin(usernameTextBox.Text, passwordTextBox.Text);

            if (dt.Rows.Count > 0)
            {
                Boolean isNurse = this.healthController.isNurse(Convert.ToInt32(dt.Rows[0]["personID"]));
                Console.WriteLine(isNurse);

                if (isNurse)
                {
                    Hide();
                    usernameTextBox.Clear();
                    passwordTextBox.Clear();
                    nd.SetTextForLabel(dt.Rows[0]["name"].ToString());
                    nd.Show();
                }
                else
                {
                    Hide();
                    usernameTextBox.Clear();
                    passwordTextBox.Clear();
                    //ad.SetTextForLabel(Convert.ToString(dt.Rows[0]["name"]));
                    //ad.Show();
                }
            }
            else
            {
                messageLabel.Text = "invalid username/password";
                messageLabel.ForeColor = Color.Red;
                messageLabel.Visible = true;
            }

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (messageLabel.Visible == true)
            {
                messageLabel.Visible = false;
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (messageLabel.Visible == true)
            {
                messageLabel.Visible = false;
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



    }
}
