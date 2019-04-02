using System;

namespace HealthCare.Model
{
    /// <summary>
    /// Gets and sets all attributes of a person
    /// </summary>
    class Person
    {
        /// <summary>
        /// The person's ID with getter and setter
        /// </summary>
        public int PersonID { get; set; }

        /// <summary>
        /// The person's last name with getter and setter
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The person's first name with getter and setter
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The person's date of birth with getter and setter
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// The person's street address with getter and setter
        /// </summary>
        public string StreetAddress { get; set; }

        /// <summary>
        /// The person's city with  getter and setter
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// The person's state as a code with getter and setter
        /// </summary>
        public string StateCode { get; set; }

        /// <summary>
        /// The person's zipcode with getter and setter
        /// </summary>
        public int ZipCode { get; set; }

        /// <summary>
        /// The person's phone number with getter and setter
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The person's social security number with getter and setter
        /// </summary>
        public string SSN { get; set; }

        /// <summary>
        /// The combined name of the person
        /// </summary>
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
