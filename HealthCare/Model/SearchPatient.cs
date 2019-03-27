using System;


namespace HealthCare.Model
{
    class SearchPatient
    {
        public int PatientID { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
