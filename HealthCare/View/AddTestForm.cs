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
    public partial class AddTestForm : Form
    {
        public int visitID;
        public AddTestForm(int visitID)
        {
            InitializeComponent();
            this.visitID = visitID;

        }
    }
}
