
using System;

namespace HealthCare.Model
{
    /// <summary>
    /// Gets and sets all attributes of an appointment
    /// </summary>
    public class Appointment
    {
        /// <summary>
        /// The appointment's ID with  getter and setter
        /// </summary>
        public int AppointmentID { get; set; }

        /// <summary>
        /// The patient's ID with getter and setter
        /// </summary>
        public int PatientID { get; set; }

        /// <summary>
        /// The doctor's ID with getter and setter
        /// </summary>
        public int DoctorID { get; set; }

        /// <summary>
        /// The Date and Time of an appointment with getter and setter
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// The reason the patient is making the appointment with getter and setter
        /// </summary>
        public string ReasonForVisit { get; set; }

        /// <summary>
        /// The Doctor's name associated with the appointment
        /// </summary>
        public string DoctorName { get; set; }
    }
}
