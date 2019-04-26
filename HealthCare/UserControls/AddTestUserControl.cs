using HealthCare.Controller;
using HealthCare.Model;
using HealthCare.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HealthCare.UserControls
{
    /// <summary>
    /// Add Test for visit
    /// </summary>
    public partial class AddTestUserControl : UserControl
    {
        private HealthcareController controller;
        private int visitID;
        private List<Test> all;
        private List<Test> ordered;

        /// <summary>
        /// Initialize user control
        /// </summary>
        public AddTestUserControl()
        {
            InitializeComponent();
            this.controller = new HealthcareController();
        }

        /// <summary>
        /// Load the available tests
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadTests(object sender, EventArgs e)
        {
            AddTestForm tf = this.ParentForm as AddTestForm;
            this.visitID = tf.VisitID;

            this.all = controller.GetAllTests();
            this.ordered = controller.GetTestsByVisitId(this.visitID);

            foreach (var test in ordered)
            {
                all.Remove(all.Single(s => s.TestCode == test.TestCode));
            }

            this.RefreshListView();
        }

        /// <summary>
        /// Process Add to order button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            this.submitOrderButton.Enabled = true;
        }

        /// <summary>
        /// Refresh the list view of items
        /// </summary>
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

        /// <summary>
        /// Process cancel button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            AddTestForm tf = this.ParentForm as AddTestForm;
            tf.Close();
        }

        /// <summary>
        /// Process submit order click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Process the test order
        /// </summary>
        /// <param name="tests"></param>
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