using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.Model
{
    class Visit
    {
        public int VisitID { get; set; }
        public int NurseID { get; set; }
        public int AppointmentID { get; set; }
        public decimal Weight { get; set; }
        public int SystolicBP { get; set; }
        public int DiastolicBP { get; set; }
        public decimal Temp { get; set; }
        public int Pulse { get; set; }
        public string Symptoms { get; set; }
    }
}
