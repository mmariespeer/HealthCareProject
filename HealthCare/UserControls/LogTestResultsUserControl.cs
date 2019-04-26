using HealthCare.Controller;
using HealthCare.View;
using System;
using System.Windows.Forms;

namespace HealthCare.UserControls
{
    /// <summary>
    /// Log test Result User Control
    /// </summary>
    public partial class LogTestResultsUserControl : UserControl
    {
        private HealthcareController controller;

        /// <summary>
        /// Initialize the component
        /// </summary>
        public LogTestResultsUserControl()
        {
            InitializeComponent();
            this.controller = new HealthcareController();
        }

        /// <summary>
        /// Update the test fill in label with the name of the test
        /// </summary>
        /// <param name="labelText"></param>
        public void UpdateLabel(string labelText)
        {
            this.testNameLabel.Text = labelText;
        }

        /// <summary>
        /// Process Cancel button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        /// <summary>
        /// Process Save button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool valid = true;
            string result = logResultText.Text;
            string pDate = performMaskedTextBox.Text;
            DateTime performDate = DateTime.MinValue;
            bool normal = normalRadioButton.Checked;
            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Please enter a result");
                valid = false;
            }
            if (!normalRadioButton.Checked && !abnormalRadioButton.Checked)
            {
                MessageBox.Show("Please select Normal or Abnormal");
                valid = false;
            }
            if (!this.performMaskedTextBox.MaskFull)
            {
                MessageBox.Show("Please enter a perform date");
                valid = false;
            }
            else
            {
                try
                {
                    performDate = DateTime.Parse(this.performMaskedTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Date entered is not a valid date.");
                    valid = false;
                }


            }
            if (valid)
            {
                var parent = this.ParentForm as LogTestResultForm;
                controller.UpdateTestResult(parent.VisitID, parent.TestCode, result, normal, performDate);
                MessageBox.Show("Test Result updated");
                ListView apptListView = parent.VisitControl.Controls["visitListView"] as ListView;
                var selectedItemIndex = apptListView.SelectedItems[0].Index;
                parent.VisitControl.VisitUserControl_Load(null, null);
                var item = apptListView.Items[selectedItemIndex];
                item.Selected = true;


                parent.Close();
            }

        }
    }
}
