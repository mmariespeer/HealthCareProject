using System;

namespace HealthCare.Model
{
    /// <summary>
    /// The nurse model class
    /// </summary>
    class Nurse
    {
        /// <summary>
        /// The nurse ID
        /// </summary>
        public int NurseID { get; set; }

        /// <summary>
        /// The personID associated with the nurse
        /// </summary>
        public int PersonID { get; set; }

        /// <summary>
        /// The nurse's last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The nurse's first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The nurse's full name
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The nurse's date of birth
        /// </summary>
        public DateTime DateOfBirth { get; set; }
    }
}
