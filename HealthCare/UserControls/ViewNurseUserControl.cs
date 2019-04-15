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


        public ViewNurseUserControl()
        {
            this.healthController = new HealthcareController();
            InitializeComponent();
            this.nurseID = 0;
            this.SetListView();

        }

        private void addButton_Click(object sender, EventArgs e)
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

                    this.healthController.addNurse(person);

                    //MessageBox.Show("New Nurse Added");
                    this.SetListView();

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
            catch (Exception ex)
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

        private void SetListView()
        {
            this.nurseListView.Items.Clear();

            try
            {
                List<Nurse> nurseList = this.healthController.GetAllNurses();

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            this.ClearForm();

            //this.nurseListView.Items.Clear();
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
                try
                {
                    this.healthController.UpdateNuse(this.currentPerson.PersonID, lName, fName, dob, streetAddress, city, state, zipCode, phoneNumber, ssn);
                    MessageBox.Show("Nurse has been updated");
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }
    }
}
