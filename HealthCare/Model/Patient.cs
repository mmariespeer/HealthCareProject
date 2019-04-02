using System;

namespace HealthCare.Model
{
    /// <summary>
    /// The patient class is used to denote a person who is also a patient and the attributes specifically pertaining to a paitent
    /// </summary>
    class Patient
    {
        /// <summary>
        /// The person ID associated with the patient with getter and setter
        /// </summary>
        public int PersonID { get; set; }

        /// <summary>
        /// The patient's ID number with getter and setter
        /// </summary>
        public int PatientID { get; set; }

        /// <summary>
        /// The patient's last name with getter and setter
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The paitent's first name with getter and setter
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The paitents full name with getter and setter
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The patients date of birth with getter and setter
        /// </summary>
        public DateTime DateOfBirth { get; set; }
    }
}
