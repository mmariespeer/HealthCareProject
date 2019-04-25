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
    public partial class MostPeformedTestsUserControl : UserControl
    {
        public MostPeformedTestsUserControl()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           this.spMostPerformedTestsTableAdapter.Fill(this.mostperformed.spMostPerformedTests, DateTime.Today, DateTime.Today);
           this.reportViewer1.RefreshReport();
            
        }

        private void generateReportButton_Click_1(object sender, EventArgs e)
        {
            this.spMostPerformedTestsTableAdapter.Fill(this.mostperformed.spMostPerformedTests, this.startDate.Value, this.endDate.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}
