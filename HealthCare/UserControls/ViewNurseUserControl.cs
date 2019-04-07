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

namespace HealthCare.UserControls
{
    public partial class ViewNurseUserControl : UserControl
    {
        private readonly HealthcareController healthController;

        public ViewNurseUserControl()
        {
            this.healthController = new HealthcareController();
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
