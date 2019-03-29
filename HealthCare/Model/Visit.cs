using System;

namespace HealthCare.Model
{
    class Visit
    {
        public int VisitID { get; set; }

        public int AppointmentID { get; set; }

        public int PatientID { get; set; }

        public int DoctorID { get; set; }

        public string DoctorName { get; set; }

        public int NurseID { get; set; }

        public DateTime DateTime { get; set; }

        public decimal Weight { get; set; }

        public int SystolicBP { get; set; }

        public int DiastolicBP { get; set; }

        public decimal Temp { get; set; }

        public int Pulse { get; set; }

        public string Symptoms { get; set; }

        public string InitialDiagnosis { get; set; }

        public string FinalDiagnosis { get; set; }
    }
}
