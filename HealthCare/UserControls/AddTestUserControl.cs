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
using HealthCare.View;

namespace HealthCare.UserControls
{
    public partial class AddTestUserControl : UserControl
    {
        private HealthcareController controller;
        private int visitID;
        private List<Test> all;
        private List<Test> ordered;
        public AddTestUserControl()
        {
            InitializeComponent();
            this.controller = new HealthcareController();
            
        }

        private void LoadTests(object sender, EventArgs e)
        {
            AddTestForm tf = this.ParentForm as AddTestForm;
            this.visitID = tf.VisitID;

            this.all = controller.GetAllTests();
            this.ordered = controller.GetTestsByVisitId(this.visitID);

            foreach(var test in ordered)
            {
                all.Remove(all.Single(s => s.TestCode == test.TestCode));
            }

            this.RefreshListView();
        }

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in availableListView.SelectedItems)
            {

                all.Remove(all.Single(s => s.TestCode == item.SubItems[0].Text));
                Test test = new Test();
                test.TestCode = item.SubItems[0].Text;
                test.TestName = item.SubItems[1].Text;
                test.VisitId = this.visitID;
                ordered.Add(test);
            }
            this.RefreshListView();
        }

        private void RefreshListView()
        {
            this.availableListView.Items.Clear();
            this.orderedListView.Items.Clear();

            if (all.Count > 0)
            {
                Test test;
                for (int i = 0; i < all.Count; i++)
                {
                    test = all[i];
                    this.availableListView.Items.Add(test.TestCode.ToString());
                    this.availableListView.Items[i].SubItems.Add(test.TestName.ToString());
                }

            }

            if (ordered.Count > 0)
            {
                Test test;
                for (int i = 0; i < ordered.Count; i++)
                {
                    test = ordered[i];
                    this.orderedListView.Items.Add(test.TestCode.ToString());
                    this.orderedListView.Items[i].SubItems.Add(test.TestName.ToString());
                    this.orderedListView.Items[i].SubItems.Add(test.TestDate == DateTime.MinValue ? string.Empty : test.TestDate.ToShortDateString());
                    this.orderedListView.Items[i].SubItems.Add(test.Results?.ToString() ?? "");
                    this.orderedListView.Items[i].SubItems.Add(test.Normal?.ToString() ?? "");
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            AddTestForm tf = this.ParentForm as AddTestForm;
            tf.Close();
        }

        private void SubmitOrderButton_Click(object sender, EventArgs e)
        {
            List<Test> tests = new List<Test>();
            OrderTests(tests);
            MessageBox.Show("Tests Ordered");
            var parent = this.ParentForm as AddTestForm;
            ListView apptListView = parent.VisitControl.Controls["visitListView"] as ListView;
            var selectedItemIndex = apptListView.SelectedItems[0].Index;
            parent.VisitControl.VisitUserControl_Load(null, null);
            var item = apptListView.Items[selectedItemIndex];
            item.Selected = true;
           
            AddTestForm tf = this.ParentForm as AddTestForm;
            tf.Close();
        }

        private void OrderTests(List<Test> tests)
        {
            foreach (var test in ordered)
            {
                if (test.TestDate == DateTime.MinValue)
                {
                    controller.OrderTest(test);
                }
            }
        }
    }
}