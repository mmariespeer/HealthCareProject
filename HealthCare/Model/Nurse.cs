﻿using System;

namespace HealthCare.Model
{
    class Nurse
    {
        public int NurseID { get; set; }

      
        public int PersonID { get; set; }

        public string LastName { get; set; }
      
        public string FirstName { get; set; }

        public string FullName { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
