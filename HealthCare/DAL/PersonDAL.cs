using HealthCare.DB;
using HealthCare.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.DAL
{
    /// <summary>
    /// Performs all DB sql statements for Person
    /// </summary>
    class PersonDAL
    {
        public Person GetPersonByID(int personID)
        {
            Person person = new Person();
            string selectStatement =
                "SELECT personID, lastName, firstName, streetAddress, city, stateCode, zipCode, phoneNumber, ssn " +
                "FROM Person " +
                "WHERE personID = @personID";

            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@personID", personID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            person.PersonID = (int)reader["personID"];
                            person.LastName = (string)reader["lastName"];
                            person.FirstName = (string)reader["firstName"];
                            //person.DateOfBirth = (DateTime)reader["dateTime"];
                            person.StreetAddress = (string)reader["streetAddress"];
                            person.City = (string)reader["city"];
                            person.StateCode = (string)reader["stateCode"];
                            person.ZipCode = (int)reader["zipCode"];
                            person.PhoneNumber = (string)reader["phoneNumber"];
                            person.SSN = (string)reader["ssn"];
                        }
                    }
                }
                return person;
            }
        }

        //Retrieves a person by the doctorsID
        public Person GetPersonByDoctorID(int docID)
        {
            Person person = new Person();
            string selectStatement =
                "SELECT lastName, firstName, doctorID " +
                "FROM Person " +
                "INNER JOIN Doctor " +
                "ON Doctor.PersonID = Person.PersonID " +
                "WHERE doctorID = @docID";

            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@docID", docID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            person.LastName = (string)reader["lastName"];
                            person.FirstName = (string)reader["firstName"];
                        }
                    }
                }
                return person;
            }
        }

        //Retrieves a person by the patientID
        public Person GetPersonByPatientID(int patientID)
        {
            Person person = new Person();
            string selectStatement =
                "SELECT Person.personID, lastName, firstName, streetAddress, city, stateCode, zipCode, phoneNumber, ssn " +
                "FROM Person " +
                "INNER JOIN Patient " +
                "ON Patient.PersonID = Person.PersonID " +
                "WHERE patientID = @patientID";

            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@patientID", patientID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            person.PersonID = (int)reader["personID"];
                            person.LastName = (string)reader["lastName"];
                            person.FirstName = (string)reader["firstName"];
                            //person.DateOfBirth = (DateTime)reader["dateTime"];
                            person.StreetAddress = (string)reader["streetAddress"];
                            person.City = (string)reader["city"];
                            person.StateCode = (string)reader["stateCode"];
                            person.ZipCode = (int)reader["zipCode"];
                            person.PhoneNumber = (string)reader["phoneNumber"];
                            person.SSN = (string)reader["ssn"];
                        }
                    }
                }
                return person;
            }
        }
    }
    
}
