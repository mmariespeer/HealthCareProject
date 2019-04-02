using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HealthCare.Controller;
using HealthCare.Model;
using HealthCare.View;

namespace HealthCare.UserControls
{
    public partial class RegisterPatientUserControl : UserControl
    {
        private readonly HealthcareController healthController;
        private List<State> stateList;
        private int patientID;
        private Person currentPerson;

        public RegisterPatientUserControl()
        {
            InitializeComponent();
            this.healthController = new HealthcareController();
            this.patientID = 0;
        }

        /// <summary>
        /// load the patient user control in the nurse dashboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RegisterPatientUserControl_Load(object sender, EventArgs e)
        {

            try
            {
                NurseDashboard dashboard = this.ParentForm as NurseDashboard;
                this.patientID = dashboard.SelectedPatientID;
            } catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
    

                try
                {
                    stateList = this.healthController.GetAllStates();

                    stateCodeComboBox.DataSource = stateList;
                    stateCodeComboBox.DisplayMember = "stateName";
                    stateCodeComboBox.ValueMember = "stateCode";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (this.patientID != 0)
                {
                    this.PopulatePatient();
                    this.updateButton.Enabled = true;
                    this.deleteButton.Enabled = true;
                    this.registerButton.Enabled = false;
                    this.clearButton.Enabled = false;
                    this.ssnTextBox.ReadOnly = true;
                    this.DOBDateTimePicker.Enabled = false;

            }
                else
                {
                    this.updateButton.Enabled = false;
                    this.deleteButton.Enabled = false;
                    this.registerButton.Enabled = true;
                    this.clearButton.Enabled = true;
                    this.ClearForm();
                    this.ssnTextBox.ReadOnly = false;
                    this.DOBDateTimePicker.Enabled = true;
            }
            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(this.lastNameTextBox.Text) || String.IsNullOrEmpty(this.firstNameTextBox.Text) || String.IsNullOrEmpty(this.cityTextBox.Text) || !this.phoneTextBox.MaskFull ||
                 !this.ssnTextBox.MaskFull || String.IsNullOrEmpty(this.addressTextBox.Text) || !this.zipTextBox.MaskFull || this.DOBDateTimePicker.Value == null)
            {
                MessageBox.Show("All fields must be filled in completely. SSN must be 9 digits, phone must be 10 digits, and zipcode must be 5 digits", "Invalid input format",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
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

                    MessageBox.Show("New Patient Registered");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.lastNameTextBox.Text) || String.IsNullOrEmpty(this.firstNameTextBox.Text) || String.IsNullOrEmpty(this.cityTextBox.Text) || !this.phoneTextBox.MaskFull ||
               String.IsNullOrEmpty(this.addressTextBox.Text) || !this.zipTextBox.MaskFull)
            {
                MessageBox.Show("All fields must be filled in completely. Phone must be 10 digits and zipcode must be 5 digits", "Invalid input format",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string lastName = this.lastNameTextBox.Text;
                string firstName = this.firstNameTextBox.Text;
                string city = this.cityTextBox.Text;
                string PhoneNumber = this.phoneTextBox.Text;
                string StreetAddress = this.addressTextBox.Text;
                string StateCode = stateList[this.stateCodeComboBox.SelectedIndex].stateCode;
                int ZipCode = Convert.ToInt32(this.zipTextBox.Text);

                try
                {
                    this.healthController.updatePatient(this.currentPerson.PersonID, lastName, ZipCode, firstName, StreetAddress, city, StateCode, PhoneNumber);
                    MessageBox.Show("Patient has been updated");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void PopulatePatient()
        {
            try
            {
                this.currentPerson = this.healthController.GetPersonByPatientID(this.patientID);
                this.lastNameTextBox.Text = currentPerson.LastName;
                this.firstNameTextBox.Text = currentPerson.FirstName;
                this.cityTextBox.Text = this.currentPerson.City;
                this.phoneTextBox.Text = this.currentPerson.PhoneNumber;
                this.ssnTextBox.Text = currentPerson.SSN;
                this.addressTextBox.Text = currentPerson.StreetAddress;
                this.stateCodeComboBox.SelectedIndex = this.stateCodeComboBox.FindStringExact(this.healthController.findStateNamebyCode(currentPerson.StateCode));
                this.zipTextBox.Text = this.currentPerson.ZipCode.ToString();
                this.DOBDateTimePicker.Value = this.currentPerson.DateOfBirth;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void ClearForm()
        {
            this.addressTextBox.Clear();
            this.cityTextBox.Clear();
            this.zipTextBox.Clear();
            this.phoneTextBox.Clear();
            this.ssnTextBox.Clear();
            this.lastNameTextBox.Clear();
            this.firstNameTextBox.Clear();
            this.stateCodeComboBox.SelectedIndex = 0;
            
        }

    }
}
