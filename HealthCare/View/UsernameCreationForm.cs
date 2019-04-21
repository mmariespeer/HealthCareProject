using HealthCare.UserControls;
using System.Windows.Forms;

namespace HealthCare.View
{
    public partial class UsernameCreationForm : Form
    {
        public int PersonID;
        public ViewNurseUserControl ViewNurseControl;

        public UsernameCreationForm(int personID, ViewNurseUserControl viewNurseControl)
        {
            InitializeComponent();
            this.PersonID = personID;
            this.ViewNurseControl = viewNurseControl;
        }
    }
}
