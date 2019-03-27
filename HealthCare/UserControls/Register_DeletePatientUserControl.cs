using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare.UserControls
{
    public partial class Register_DeletePatientUserControl : UserControl
    {
        public Register_DeletePatientUserControl()
        {
            InitializeComponent();
        }

        private void patientSearchUserControl2_Load(object sender, EventArgs e)
        {
            
        }

        private void InitializeComponent()
        {
            this.patientSearchUserControl1 = new HealthCare.UserControls.PatientSearchUserControl();
            this.SuspendLayout();
            // 
            // patientSearchUserControl1
            // 
            this.patientSearchUserControl1.Location = new System.Drawing.Point(8, 7);
            this.patientSearchUserControl1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.patientSearchUserControl1.Name = "patientSearchUserControl1";
            this.patientSearchUserControl1.Size = new System.Drawing.Size(1395, 968);
            this.patientSearchUserControl1.TabIndex = 0;
            // 
            // Register_DeletePatientUserControl
            // 
            this.Controls.Add(this.patientSearchUserControl1);
            this.Name = "Register_DeletePatientUserControl";
            this.Size = new System.Drawing.Size(1411, 982);
            this.ResumeLayout(false);

        }
    }
}
