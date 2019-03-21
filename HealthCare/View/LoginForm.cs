using System;
using System.Drawing;
using System.Windows.Forms;

namespace HealthCare.View
{
    public partial class LoginForm : Form
    {
       // private MainDashboard md;

        public LoginForm()
        {
            InitializeComponent();
           // md = new MainDashboard(this);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if ((usernameTextBox.Text == ) && (passwordTextBox.Text == ))
            {
                Hide();
                usernameTextBox.Clear();
                passwordTextBox.Clear();
               // md.Show();
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



    }
}
