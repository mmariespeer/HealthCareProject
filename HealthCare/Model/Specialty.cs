namespace HealthCare.Model
{
    /// <summary>
    /// Specialty class relating to a doctor's 1 or more specialties
    /// </summary>
    class Specialty
    {
        /// <summary>
        /// The name of the specialty
        /// </summary>
        public string SpecialityName { get; set; }

        /// <summary>
        /// The doctor's Id 
        /// </summary>
        public int DoctorID { get; set; }

        /// <summary>
        /// The description of the specialty
        /// </summary>
        public string SpecialityDescription { get; set; }
    }
}
