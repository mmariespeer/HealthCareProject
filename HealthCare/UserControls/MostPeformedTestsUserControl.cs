using System;
using System.Windows.Forms;

namespace HealthCare.UserControls
{
    /// <summary>
    /// Most performed test user control
    /// </summary>
    public partial class MostPeformedTestsUserControl : UserControl
    {
        /// <summary>
        /// Initialize component
        /// </summary>
        public MostPeformedTestsUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load the report viewer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reportViewer1_Load(object sender, EventArgs e)
        {

            this.spMostPerformedTestsTableAdapter.Fill(this.mostPerformedTests.spMostPerformedTests, DateTime.Today, DateTime.Today);
            this.reportViewer1.RefreshReport();

        }

        /// <summary>
        /// Process the generate report button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generateReportButton_Click_1(object sender, EventArgs e)
        {
            this.spMostPerformedTestsTableAdapter.Fill(this.mostPerformedTests.spMostPerformedTests, this.startDate.Value, this.endDate.Value);
            this.reportViewer1.RefreshReport();
        }
    }
}
