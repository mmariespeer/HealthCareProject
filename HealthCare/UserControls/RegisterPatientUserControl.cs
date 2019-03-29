using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthCare.Controller;
using HealthCare.Model;

namespace HealthCare.UserControls
{
    public partial class RegisterPatientUserControl : UserControl
    {
        private readonly HealthcareController healthController;
        private List<State> stateList; 
        public RegisterPatientUserControl()
        {
            InitializeComponent();
            this.healthController = new HealthcareController();
        }
        private void RegisterPatientUserControl_Load(object sender, EventArgs e)
        {
            try
            {
                stateList = this.healthController.GetAllStates();

                stateCodeComboBox.DataSource = stateList;
                stateCodeComboBox.DisplayMember = "stateName";
                stateCodeComboBox.ValueMember = "stateCode";

                stateCodeComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.addressTextBox.Clear();
            this.cityTextBox.Clear();
            this.zipTextBox.Clear();
            this.phoneTextBox.Clear();
            this.ssnTextBox.Clear();
            this.lastNameTextBox.Clear();
            this.firstNameTextBox.Clear();
            stateCodeComboBox.SelectedIndex = 0;
            this.DOBDateTimePicker.CustomFormat = " ";
            this.DOBDateTimePicker.Format = DateTimePickerFormat.Custom;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

           if (String.IsNullOrEmpty(this.lastNameTextBox.Text)|| String.IsNullOrEmpty(this.firstNameTextBox.Text) || String.IsNullOrEmpty(this.cityTextBox.Text) || !this.phoneTextBox.MaskFull ||
                !this.ssnTextBox.MaskFull || String.IsNullOrEmpty(this.addressTextBox.Text) || !this.zipTextBox.MaskFull || this.DOBDateTimePicker.Value == null)
            {
                MessageBox.Show("All fields must be filled in completely. SSN must be 9 digits, phone must be 10 digits, and zipcode must be 5 digits", "Invalid input format",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Person person = new Person();
                person.LastName = this.lastNameTextBox.Text;
                person.FirstName = this.firstNameTextBox.Text;
                person.City = this.cityTextBox.Text;
                person.PhoneNumber = this.phoneTextBox.Text;
                person.SSN = this.ssnTextBox.Text;
                person.StreetAddress = this.addressTextBox.Text;
                person.StateCode = stateList[this.stateCodeComboBox.SelectedIndex].stateCode;
                person.ZipCode = Convert.ToInt32(this.zipTextBox.Text);
                person.DateOfBirth = this.DOBDateTimePicker.Value;

                this.healthController.registerPatient(person);

                confirmLabel.ForeColor = Color.Green;
                confirmLabel.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

       
    }
}
