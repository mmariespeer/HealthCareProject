using HealthCare.DB;
using HealthCare.Model;
using System;
using System.Data.SqlClient;


namespace HealthCare.DAL
{
    /// <summary>
    /// Performs all DB sql statements for Person
    /// </summary>
    class PersonDAL
    {   

       /// <summary>
       /// get a person by their person id
       /// </summary>
       /// <param name="personID"></param>
       /// <returns>a person searched by personID</returns>
        public Person GetPersonByID(int personID)
        {
            Person person = new Person();
            string selectStatement =
                "SELECT personID, lastName, firstName, dateOfBirth, streetAddress, city, stateCode, zipCode, phoneNumber, ssn " +
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
                            person.DateOfBirth = (DateTime)reader["dateOfBirth"];
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

        /// <summary>
        /// Retrieves a person by the doctorsID
        /// </summary>
        /// <param name="docID">doctorID to search</param>
        /// <returns>Person of that doctorID</returns>
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

        /// <summary>
        /// Retrieves a person by the patientID
        /// </summary>
        /// <param name="patientID">patientID to search</param>
        /// <returns>Person fo that patientID</returns>
        public Person GetPersonByPatientID(int patientID)
        {
            Person person = new Person();
            string selectStatement =
                "SELECT Person.personID, lastName, firstName, dateOfBirth, streetAddress, city, stateCode, zipCode, phoneNumber, ssn " +
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
                            person.DateOfBirth = (DateTime)reader["dateOfBirth"];
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

        /// <summary>
        /// Get PErson by nurse ID
        /// </summary>
        /// <param name="nurseID"></param>
        /// <returns></returns>
        public Person GetPersonByNurseID(int nurseID)
        {
            Person person = new Person();
            string selectStatement =
                "SELECT Person.personID, lastName, firstName, dateOfBirth, streetAddress, city, stateCode, zipCode, phoneNumber, ssn " +
                "FROM Person " +
                "INNER JOIN nurse " +
                "ON nurse.PersonID = Person.PersonID " +
                "WHERE nurseID = @nurseID";

            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@nurseID", nurseID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            person.PersonID = (int)reader["personID"];
                            person.LastName = (string)reader["lastName"];
                            person.FirstName = (string)reader["firstName"];
                            person.DateOfBirth = (DateTime)reader["dateOfBirth"];
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

        /// <summary>
        /// Get a personID from a patientID
        /// </summary>
        /// <param name="patientID"></param>
        /// <returns>a personID </returns>
        public int GetPersonID(int patientID)
        {
            int id;

            string selectStatement = "SELECT p.personID FROM person p JOIN patient pa ON pa.personID = p.personID WHERE pa.patientID = @patientID";

            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@patientID", patientID);
                    id = (int)selectCommand.ExecuteScalar();
                }
                return id;
            }
        }

    }

}
