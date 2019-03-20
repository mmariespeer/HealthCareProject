
using System;

namespace HealthCare.Model
{
    /// <summary>
    /// Gets and sets all attributes of an appointment
    /// </summary>
    public class Appointment
    {
        public int appointmentID { get; set; }
        
        public int patientID { get; set; }

        public int doctorID { get; set; }
        
        public DateTime dateTime { get; set; }

        public string reasonForVisit { get; set; }
    }
}
