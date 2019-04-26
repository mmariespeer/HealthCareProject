using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HealthCare.Controller;
using HealthCare.Model;
using HealthCare.View;

namespace HealthCare.UserControls
{
    public partial class ViewNurseUserControl : UserControl
    {
        private readonly HealthcareController healthController;
        private List<State> stateList;
        private Person currentPerson;
        private int nurseID;
        private UsernameCreationForm addUsername;
        public static int personID;

        public ViewNurseUserControl()
        {
            this.healthController = new HealthcareController();
            InitializeComponent();
            this.nurseID = 0;
            this.SetListView();
            this.nurseListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            this.nurseListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            this.nurseListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
            this.nurseListView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
            this.nurseListView.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.lastNameTextBox.Text) || String.IsNullOrEmpty(this.firstNameTextBox.Text) || String.IsNullOrEmpty(this.cityTextBox.Text) || !this.phoneTextBox.MaskFull ||
                 !this.ssnTextBox.MaskFull || String.IsNullOrEmpty(this.addressTextBox.Text) || !this.zipTextBox.MaskFull || this.DOBDateTimePicker.Value == null || 
                 (!this.activeRadioButton.Checked && !this.inactiveRadioButton.Checked)
                 )
            {
                MessageBox.Show("All fields must be filled in completely. SSN must be 9 digits, phone must be 10 digits, and zipcode must be 5 digits." +
                    " Nurse must be marked as either active or inactive", "Invalid input format",
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

                    string active = "";
                   if (activeRadioButton.Checked)
                    {
                        active = "true";
                    } else
                    {
                        active = "false";
                    }

                    if (this.healthController.addNurse(person, active))
                    {
                        
                        personID = person.PersonID;
                        MessageBox.Show("New Nurse Added! Please create their username and password.");
                        this.SetListView();
                        int nurseID = int.Parse(nurseListView.Items[(nurseListView.Items.Count - 1)].Text);
                        Person latest = this.healthController.GetPersonByNurseID(nurseID);
                        this.addUsername = new UsernameCreationForm(latest.PersonID, this);
                        this.addUsername.ShowDialog();
                        this.addButton.Enabled = false;
                        this.updateButton.Enabled = true;
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

        public void ViewNurseUserControl_Load(object sender, EventArgs e)
        {

            try
            {
                AdminDashboard dashboard = this.ParentForm as AdminDashboard;
                this.nurseID = dashboard.SelectedNurseID;
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

            if (this.nurseID != 0)
            {
                this.PopulateNurse();
                this.updateButton.Enabled = true;
                this.addButton.Enabled = false;
            }
            else
            {
                this.updateButton.Enabled = false;
                this.addButton.Enabled = true;
                this.ClearForm();
            }

        }

        private List<Nurse> SetListView()
        {
            this.nurseListView.Items.Clear();
            List<Nurse> nurseList = this.healthController.GetAllNurses();
            try
            {
                Nurse nurse;
                for (int i = 0; i < nurseList.Count; i++)
                {
                    nurse = nurseList[i];
                    this.nurseListView.Items.Add(nurse.NurseID.ToString());
                    this.nurseListView.Items[i].SubItems.Add(nurse.LastName.ToString());
                    this.nurseListView.Items[i].SubItems.Add(nurse.FirstName.ToString());
                    this.nurseListView.Items[i].SubItems.Add(nurse.DateOfBirth.ToShortDateString());
                }
                this.nurseListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                this.nurseListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
                this.nurseListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
                this.nurseListView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
                this.nurseListView.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
                return nurseList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return nurseList;
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            this.ClearForm();

            AdminDashboard dashboard = this.ParentForm as AdminDashboard;
            dashboard.SelectedNurseID = 0;
            dashboard.RefreshTabs(sender, e);

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
            this.activeRadioButton.Checked = false;
            this.inactiveRadioButton.Checked = false;
            this.DOBDateTimePicker.Value = DateTime.Now;

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (this.lastNameTextBox.Text == null || this.lastNameTextBox.Text == "" ||
                this.firstNameTextBox.Text == null || this.firstNameTextBox.Text == "" ||
                this.cityTextBox.Text == null || this.cityTextBox.Text == "" ||
                !this.phoneTextBox.MaskFull ||
                !this.ssnTextBox.MaskFull ||
                this.addressTextBox.Text == null || this.addressTextBox.Text == "" ||
                !this.zipTextBox.MaskFull ||
                !this.ssnTextBox.MaskFull ||
                this.DOBDateTimePicker.Value == null)
            {
                MessageBox.Show("All fields must be filled in completely. SSN must be 9 digits, phone must be 10 digits, and zipcode must be 5 digits", "Invalid input format",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string lName = this.lastNameTextBox.Text;
                string fName = this.firstNameTextBox.Text;
                DateTime dob = this.DOBDateTimePicker.Value;
                string city = this.cityTextBox.Text;
                string streetAddress = this.addressTextBox.Text;
                string state = stateList[this.stateCodeComboBox.SelectedIndex].stateCode;
                int zipCode = Convert.ToInt32(this.zipTextBox.Text);
                string phoneNumber = this.phoneTextBox.Text;
                string ssn = this.ssnTextBox.Text;

                string active = "";
                if (activeRadioButton.Checked)
                {
                    active = "true";
                }
                else
                {
                    active = "false";
                }

                try
                {
                    this.healthController.UpdateNurse(this.currentPerson.PersonID, lName, fName, dob, streetAddress, city, state, zipCode, phoneNumber, ssn, active);
                    MessageBox.Show("Nurse has been updated");
                    this.SetListView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }

        }

        private void nurseListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.nurseListView.SelectedItems.Count == 0)
            {
                return;
            }
            AdminDashboard dashboard = this.ParentForm as AdminDashboard;
            dashboard.SelectedNurseID = int.Parse(this.nurseListView.SelectedItems[0].SubItems[0].Text);
            dashboard.RefreshTabs(sender, e);
        }

        private void PopulateNurse()
        {
            try
            {
                this.currentPerson = this.healthController.GetPersonByNurseID(this.nurseID);
                this.lastNameTextBox.Text = currentPerson.LastName;
                this.firstNameTextBox.Text = currentPerson.FirstName;
                this.cityTextBox.Text = this.currentPerson.City;
                this.phoneTextBox.Text = this.currentPerson.PhoneNumber;
                this.ssnTextBox.Text = currentPerson.SSN;
                this.addressTextBox.Text = currentPerson.StreetAddress;
                this.stateCodeComboBox.SelectedIndex = this.stateCodeComboBox.FindStringExact(this.healthController.findStateNamebyCode(currentPerson.StateCode));
                this.zipTextBox.Text = this.currentPerson.ZipCode.ToString();
                this.DOBDateTimePicker.Value = this.currentPerson.DateOfBirth;

                if (this.healthController.GetNurseStatus(this.nurseID) == 1)
                {
                    this.activeRadioButton.Checked = true;
                }
                else if (this.healthController.GetNurseStatus(this.nurseID) == 0)
                {
                    this.inactiveRadioButton.Checked = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }
    }
}
