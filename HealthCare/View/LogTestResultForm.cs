using HealthCare.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare.View
{
    public partial class LogTestResultForm : Form
    {
        public int VisitID { get; set; }
        public string TestCode { get; set; }

        public VisitUserControl VisitControl { get; set; }
        public LogTestResultForm(int visitID,string testCode, VisitUserControl visitControl)
        {
            InitializeComponent();
            this.VisitID = visitID;
            this.TestCode = testCode;
            this.VisitControl = visitControl;
        }
    }
}
