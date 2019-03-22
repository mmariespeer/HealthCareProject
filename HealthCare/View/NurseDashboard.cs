using System.Windows.Forms;
using HealthCare.Controller;

namespace HealthCare.View
{
    public partial class NurseDashboard : Form
    {
        private LoginForm lf;
        private readonly HealthcareController healthController;

        public NurseDashboard(LoginForm lf)
        {
            InitializeComponent();
            this.healthController = new HealthcareController();
            this.lf = lf;
        }

        /// <summary>
        /// set the text for nameLabel
        /// </summary>
        /// <param name="myText"></param>
        public void SetTextForLabel(string myText)
        {
            this.nameLabel.Text = myText;
        }

        private void logoutLinkDashboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            lf.Show();
        }

    }
}
