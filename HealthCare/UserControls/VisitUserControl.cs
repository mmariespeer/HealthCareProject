using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthCare.View;

namespace HealthCare.UserControls
{
    public partial class VisitUserControl : UserControl
    {
        public VisitUserControl()
        {
            InitializeComponent();
        }

        public void VisitUserControl_Load(object sender, EventArgs e)
        {
            NurseDashboard dashboard = this.ParentForm as NurseDashboard;
            this.testLabel.Text = dashboard.SelectedPatientID.ToString(); 
        }
    }
}
