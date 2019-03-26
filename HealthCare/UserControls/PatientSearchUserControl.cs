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
    public partial class PatientSearchUserControl : UserControl
    {
        public PatientSearchUserControl()
        {
            InitializeComponent();
        }

        private void PatientSearchUserControl_Load(object sender, EventArgs e)
        {
            try
            {
                technicianList = this.incidentController.GetAllTechnicians();

                nameComboBox1.DataSource = technicianList;
                nameComboBox1.SelectedIndex = 0;

                incidentList = this.incidentController.GetOpenIncidentsByTechnician(technicianList[0].TechID);
                incidentDataGridView.DataSource = incidentList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
