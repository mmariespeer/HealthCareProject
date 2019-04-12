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
        public AddTestUserControl()
        {
            InitializeComponent();
            this.controller = new HealthcareController();
            
        }

        private void LoadTests(object sender, EventArgs e)
        {
            AddTestForm tf = this.ParentForm as AddTestForm;
            this.visitID = tf.visitID;

            List<Test> all = controller.GetAllTests();
            List<Test> ordered = controller.GetTestsByVisitId(this.visitID);

            foreach(var test in ordered)
            {
                all.Remove(all.Single(s => s.TestCode == test.TestCode));
            }

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
