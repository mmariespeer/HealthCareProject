using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthCare.Model;
using HealthCare.View;
using HealthCare.Controller;

namespace HealthCare.UserControls
{
    public partial class NewLoginUserControl : UserControl
    {
        private HashingService hashing;
        private HealthcareController healthcareController;

        public NewLoginUserControl()
        {
            InitializeComponent();
            hashing = new HashingService();
            healthcareController = new HealthcareController();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {

            if (this.passwordTextBox.Text == this.confirmPasswordTextBox.Text)
            {
                Login login = new Login();
                login.UserName = this.usernameTextBox.Text;
                login.Password = hashing.PasswordHashing(this.passwordTextBox.Text);
                var parent = this.ParentForm as UsernameCreationForm;
                login.PersonID = parent.PersonID;
                healthcareController.AddLogin(login);
                parent.Close();
                MessageBox.Show("Username and password created successfully!");
            }
            else
            {
                MessageBox.Show("Passwords must match.");
                return;
            }
        }
    }
}
