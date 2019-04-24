using System;

namespace HealthCare.Model
{
    /// <summary>
    /// The visit model represents a patients visit to the doctors office
    /// </summary>
    class Visit
    {
        /// <summary>
        /// The visits ID with getter and setter
        /// </summary>
        public int VisitID { get; set; }

        /// <summary>
        /// The appointmentID associated with a specific visit with getter and setter
        /// </summary>
        public int AppointmentID { get; set; }

        /// <summary>
        /// The patientID associated with a specific visit with getter and setter
        /// </summary>
        public int PatientID { get; set; }

        /// <summary>
        /// The doctorID associated with a specific getter and setter
        /// </summary>
        public int DoctorID { get; set; }

        /// <summary>
        /// The doctor's name associated with a visit with getter and setter
        /// </summary>
        public string DoctorName { get; set; }

        /// <summary>
        /// The nurseID associated with a visit with getter and setter
        /// </summary>
        public int NurseID { get; set; }

        /// <summary>
        /// The  Date time of the visit with getter and setter
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// The weight of the patient at visit with getter and setter
        /// </summary>
        public decimal Weight { get; set; }

        /// <summary>
        /// The Systolic Blood Pressure of patient at visit with getter and setter
        /// </summary>
        public int SystolicBP { get; set; }

        /// <summary>
        /// The Diastolic Blood Pressure of patient at visit with getter and setter
        /// </summary>
        public int DiastolicBP { get; set; }

        /// <summary>
        /// The temperature of patient at visit with getter and setter
        /// </summary>
        public decimal Temp { get; set; }

        /// <summary>
        /// The pulse of the patient at visit with getter and setter
        /// </summary>
        public int Pulse { get; set; }

        /// <summary>
        /// The sypmtoms of the patient at visit with getter and setter
        /// </summary>
        public string Symptoms { get; set; }

        /// <summary>
        /// The initial diagnosis of the patient at visit with getter and setter
        /// </summary>
        public string InitialDiagnosis { get; set; }

        /// <summary>
        /// The final diagnosis of the patient at visit with getter and setter
        /// </summary>
        public string FinalDiagnosis { get; set; }

        /// <summary>
        /// The status of the appt. 0 is open 1 is closed
        /// </summary>
        public int Status { get; set; }
    }
}
