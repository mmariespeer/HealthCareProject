using System;

namespace HealthCare.Model
{
    /// <summary>
    /// Gets and sets all attributes of a person
    /// </summary>
    class Person
    {
        public int PersonID { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string StateCode { get; set; }

        public int ZipCode { get; set; }

        public string PhoneNumber { get; set; }

        public string SSN { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
