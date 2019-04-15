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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            bool valid = true;
            string result = logResultText.Text;
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

            if (valid)
            {
                var parent = this.ParentForm as LogTestResultForm;
                controller.UpdateTestResult(parent.VisitID, parent.TestCode, result, normal);
                MessageBox.Show("TestResult updated");
                parent.VisitControl.VisitUserControl_Load(null, null);
                ListView apptListView = parent.VisitControl.Controls["visitListView"] as ListView;
                var items = apptListView.Items;
                foreach(ListViewItem item in items)
                {
                    if(item.SubItems[0].Text == parent.VisitID.ToString())
                    {
                        item.Selected = true;
                        break;
                    }
                }
                apptListView.Select();
                parent.Close();                
            }
            
        }
    }
}
