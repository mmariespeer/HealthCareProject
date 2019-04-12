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
            this.visitID = tf.visitID;

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
                }
            }
        }
    }
}
