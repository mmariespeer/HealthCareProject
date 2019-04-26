namespace HealthCare.Model
{
    /// <summary>
    /// The Login class for managing client login information
    /// </summary>
    public class Login
    {
        /// <summary>
        /// The person ID associated with the login
        /// </summary>
        public int PersonID { get; set; }

        /// <summary>
        /// The username associated with the login
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// The password associated with the login
        /// </summary>
        public string Password { get; set; }
    }
}
