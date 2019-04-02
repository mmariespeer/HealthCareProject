
namespace HealthCare.Model
{
    /// <summary>
    /// Gets and sets all attributes of a doctor
    /// </summary>
    class Doctor
    {
        /// <summary>
        /// The doctor's ID number with getter and setter
        /// </summary>
        public int DoctorID { get; set; }

        /// <summary>
        /// The person ID number associated with specific doctorID with getter and setter
        /// </summary>
        public int PersonID { get; set; }
    }

}
