using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.Model
{
    public class Test
    {
        public string TestCode { get; set; }

        public string TestName { get; set; }

        public int VisitId { get; set; }

        public string Results { get; set; }

        public bool? Normal { get; set; }

        public DateTime TestDate { get; set; }
    }
}
