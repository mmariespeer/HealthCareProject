using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HealthCare.DB;
using HealthCare.Model;

namespace HealthCare.DAL
{
    class PatientDAL
    {
        public void registerPatient(Person person)
        {
            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string insertStatement = "INSERT Person(lastName, firstName, dateOfBirth, streetAddress, city, stateCode, zipCode, phoneNumber, ssn) " +
                   "VALUES(@lastName, @firstName, @dateOfBirth, @streetAddress, @city, @stateCode, @zipCode, @phoneNumber, @ssn)";

                    SqlCommand insertCommand = new SqlCommand(insertStatement, connection, transaction);
                    insertCommand.Parameters.AddWithValue("@lastName", person.LastName);
                    insertCommand.Parameters.AddWithValue("@firstName", person.FirstName);
                    insertCommand.Parameters.AddWithValue("@dateOfBirth", person.DateOfBirth.Date);
                    insertCommand.Parameters.AddWithValue("@streetAddress", person.StreetAddress);
                    insertCommand.Parameters.AddWithValue("@city", person.City);
                    insertCommand.Parameters.AddWithValue("@stateCode", person.StateCode);
                    insertCommand.Parameters.AddWithValue("@zipCode", person.ZipCode);
                    insertCommand.Parameters.AddWithValue("@phoneNumber", person.PhoneNumber);
                    insertCommand.Parameters.AddWithValue("@ssn", person.SSN);
                    insertCommand.ExecuteNonQuery();

                    insertCommand = new SqlCommand("INSERT patient (personID) VALUES ((SELECT IDENT_CURRENT('person')))", connection, transaction);
                    insertCommand.ExecuteNonQuery();
                    transaction.Commit();
 
                }
                catch
                {
                    transaction.Rollback();
                }
            }
               
        }

        public List<State> GetAllStates()
        {
            List<State> allStates = new List<State>();
            string selectStatement = "SELECT * FROM state";

            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();

                SqlCommand sc = new SqlCommand(selectStatement, connection);
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            State state = new State();
                            state.stateCode = reader["stateCode"].ToString();
                            state.stateName = reader["stateName"].ToString();

                            allStates.Add(state);
                        }
                    }

                }

            }

            return allStates;
        }

        public void updatePatient(int personID, string lastName, int zipCode, string firstName, string street, string city, string state, string phone)
        {
            string updateStatement = "UPDATE person SET firstName = @firstName, lastName = @lastName, stateCode = @stateCode, phoneNumber = @phone, streetAddress = @street, " +
                                      "city = @city, zipCode = @zip WHERE personID = @id";
            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("@id", personID);
                    updateCommand.Parameters.AddWithValue("@lastName", lastName);
                    updateCommand.Parameters.AddWithValue("@firstName", firstName);
                    updateCommand.Parameters.AddWithValue("@street", street);
                    updateCommand.Parameters.AddWithValue("@city", city);
                    updateCommand.Parameters.AddWithValue("@stateCode", state);
                    updateCommand.Parameters.AddWithValue("@zip", zipCode);
                    updateCommand.Parameters.AddWithValue("@phone", phone);
                    updateCommand.ExecuteNonQuery();
                }
            }
        }

        public String findStateNamebyCode(string stateCode)
        {
            string stateName = "";
            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand("SELECT stateName FROM state where stateCode = @code", connection))
                {
                    selectCommand.Parameters.AddWithValue("@code", stateCode);
                    stateName = selectCommand.ExecuteScalar().ToString();
                }
            }

            return stateName;
        }

        /// <summary>
        /// return a list of patients by date of birth
        /// </summary>
        /// <param name="dob"></param>
        /// <returns>list of patients searched by date of birth</returns>
        public List<Patient> GetPatientsByDOB(DateTime dob)
        {
            List<Patient> searchList = new List<Patient>();

            string selectStatement = "SELECT p.lastName, p.firstName, p.dateOfBirth, pa.patientID FROM person p JOIN patient pa ON p.personID = pa.personID WHERE CAST(p.dateOfBirth as DATE) = @DOB";

            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@DOB", dob.ToString("yyyy-MM-dd"));

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = new Patient();
                            patient.LastName = reader["lastName"].ToString();
                            patient.FirstName = reader["firstName"].ToString();
                            patient.DateOfBirth = (DateTime)reader["dateOfBirth"];
                            patient.PatientID = Convert.ToInt32(reader["patientID"]);


                            searchList.Add(patient);
                        }
                    }
                }
            }
            return searchList;
        }

        //Gets a list of patients by their first and last name
        public List<Patient> GetPatientsByFullName(string fname, string lname)
        {
            List<Patient> searchList = new List<Patient>();

            string selectStatement = "SELECT p.lastName, p.firstName, p.dateOfBirth, pa.patientID " +
                "FROM person p " +
                "JOIN patient pa " +
                "ON p.personID = pa.personID " +
                "WHERE p.lastName = @lname AND p.firstName = @fname";

            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@lname", lname);
                    selectCommand.Parameters.AddWithValue("@fname", fname);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = new Patient();
                            patient.LastName = reader["lastName"].ToString();
                            patient.FirstName = reader["firstName"].ToString();
                            patient.DateOfBirth = (DateTime)reader["dateOfBirth"];
                            patient.PatientID = Convert.ToInt32(reader["patientID"]);


                            searchList.Add(patient);
                        }
                    }
                }
            }

            return searchList;
        }

        //Gets a list of patients by their first and last name
        public List<Patient> GetPatientsByDOBandLastName(DateTime dateOfBirth, string lname)
        {
            List<Patient> searchList = new List<Patient>();

            string selectStatement = "SELECT p.lastName, p.firstName, p.dateOfBirth, pa.patientID " +
                "FROM person p " +
                "JOIN patient pa " +
                "ON p.personID = pa.personID " +
                "WHERE p.lastName = @lname AND p.dateOfBirth = @dateOfBirth";

            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@lname", lname);
                    selectCommand.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = new Patient();
                            patient.LastName = reader["lastName"].ToString();
                            patient.FirstName = reader["firstName"].ToString();
                            patient.DateOfBirth = (DateTime)reader["dateOfBirth"];
                            patient.PatientID = Convert.ToInt32(reader["patientID"]);


                            searchList.Add(patient);
                        }
                    }
                }
            }

            return searchList;
        }
    }
}
