using HealthCare.Controller;
using HealthCare.Model;
using HealthCare.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HealthCare.UserControls
{
    /// <summary>
    /// Register Patient User Control
    /// </summary>
    public partial class RegisterPatientUserControl : UserControl
    {
        private readonly HealthcareController healthController;
        private List<State> stateList;
        private int patientID;
        private Person currentPerson;

        /// <summary>
        /// Initialize the component
        /// </summary>
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
                dashboard.CancelButton.PerformClick();
            }
            catch (Exception)
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
            }
            else
            {
                this.updateButton.Enabled = false;
                this.deleteButton.Enabled = false;
                this.registerButton.Enabled = true;
                this.clearButton.Enabled = true;
                this.ClearForm();
            }

        }

        /// <summary>
        /// Process Clear button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        /// <summary>
        /// Process Register button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    person.StateCode = stateList[this.stateCodeComboBox.SelectedIndex].StateCode;
                    person.ZipCode = Convert.ToInt32(this.zipTextBox.Text);
                    person.DateOfBirth = this.DOBDateTimePicker.Value;

                    if (this.healthController.RegisterPatient(person))
                    {
                        MessageBox.Show("New Patient Registered");
                    }
                    else
                    {
                        MessageBox.Show("Duplicate SSN is not allowed");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        /// <summary>
        /// Process update button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.lastNameTextBox.Text) || String.IsNullOrEmpty(this.firstNameTextBox.Text) || String.IsNullOrEmpty(this.cityTextBox.Text) || !this.phoneTextBox.MaskFull ||
                 !this.ssnTextBox.MaskFull || String.IsNullOrEmpty(this.addressTextBox.Text) || !this.zipTextBox.MaskFull || this.DOBDateTimePicker.Value == null)
            {
                MessageBox.Show("All fields must be filled in completely. SSN must be 9 digits, phone must be 10 digits, and zipcode must be 5 digits", "Invalid input format",
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
                string StateCode = stateList[this.stateCodeComboBox.SelectedIndex].StateCode;
                int ZipCode = Convert.ToInt32(this.zipTextBox.Text);
                string ssn = this.ssnTextBox.Text;
                DateTime dob = this.DOBDateTimePicker.Value;

                try
                {
                    this.healthController.UpdatePatient(this.currentPerson.PersonID, lastName, ZipCode, firstName, StreetAddress, city, StateCode, PhoneNumber, ssn, dob);
                    MessageBox.Show("Patient has been updated");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        /// <summary>
        /// Populate the patient
        /// </summary>
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
                this.stateCodeComboBox.SelectedIndex = this.stateCodeComboBox.FindStringExact(this.healthController.FindStateNamebyCode(currentPerson.StateCode));
                this.zipTextBox.Text = this.currentPerson.ZipCode.ToString();
                this.DOBDateTimePicker.Value = this.currentPerson.DateOfBirth;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        /// <summary>
        /// Clear the form
        /// </summary>
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
            this.DOBDateTimePicker.ResetText();

        }

        /// <summary>
        /// Process the delete button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.healthController.GetAppointmentsByPatientID(this.patientID).Count != 0)
                {
                    MessageBox.Show("Pateint still has active appointments and can't be deleted");
                }
                else
                {
                    if (this.healthController.DeletePatient(this.patientID))
                    {
                        MessageBox.Show("Patient has been deleted");
                        this.ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Patient could not be deleted due to database error. Please try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }
    }
}
