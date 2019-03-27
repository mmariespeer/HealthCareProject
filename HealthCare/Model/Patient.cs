using System;

namespace HealthCare.Model
{
    class Patient
    {

        public int PersonID { get; set; }

       public string LastName { get; set; }

        public string FullName { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
