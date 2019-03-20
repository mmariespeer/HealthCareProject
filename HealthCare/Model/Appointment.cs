
using System;

namespace HealthCare.Model
{
    /// <summary>
    /// Gets and sets all attributes of an appointment
    /// </summary>
    public class Appointment
    {
        public int AppointmentID { get; set; }
        
        public int PatientID { get; set; }

        public int DoctorID { get; set; }
        
        public DateTime DateTime { get; set; }

        public string ReasonForVisit { get; set; }
    }
}
