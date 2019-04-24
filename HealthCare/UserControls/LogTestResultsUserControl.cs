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
using HealthCare.View;

namespace HealthCare.UserControls
{
    public partial class LogTestResultsUserControl : UserControl
    {
        private HealthcareController controller;
        public LogTestResultsUserControl()
        {
            InitializeComponent();
            this.controller = new HealthcareController();
        }

        public void UpdateLabel(string labelText)
        {
            this.testNameLabel.Text = labelText;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
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
            } else
            {
                try
                {
                    performDate = DateTime.Parse(this.performMaskedTextBox.Text);
                } catch
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
