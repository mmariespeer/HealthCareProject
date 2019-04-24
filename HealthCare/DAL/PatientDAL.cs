using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HealthCare.DB;
using HealthCare.Model;

namespace HealthCare.DAL
{
    class PatientDAL
    {
        /// <summary>
        /// add a new patient
        /// </summary>
        /// <param name="person"></param>
        public Boolean registerPatient(Person person)
        {
            Boolean success = false;

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
                    success = true;
                }
                catch
                {
                    transaction.Rollback();
                }
            }

            return success;
        }

        /// <summary>
        /// return a list of all states
        /// </summary>
        /// <returns>list of 50 states</returns>
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

        /// <summary>
        /// update a patients personal information
        /// </summary>
        /// <param name="personID"></param>
        /// <param name="lastName"></param>
        /// <param name="zipCode"></param>
        /// <param name="firstName"></param>
        /// <param name="street"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="phone"></param>
        public void updatePatient(int personID, string lastName, int zipCode, string firstName, string street, string city, string state, string phone, string ssn, DateTime dob)
        {
            string updateStatement = "UPDATE person SET firstName = @firstName, lastName = @lastName, stateCode = @stateCode, phoneNumber = @phone, streetAddress = @street, " +
                                      "city = @city, zipCode = @zip, ssn = @ssn, dateOfBirth = @dob WHERE personID = @id";
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
                    updateCommand.Parameters.AddWithValue("@ssn", ssn);
                    updateCommand.Parameters.AddWithValue("@dob", dob.Date);
                    updateCommand.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// return a state name based on its code
        /// </summary>
        /// <param name="stateCode"></param>
        /// <returns>name of a state</returns>
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

        /// <summary>
        /// Gets a list of patients by their first and last name
        /// </summary>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <returns>list of patient's full name</returns>
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

        /// <summary>
        /// Gets a list of patients by their last name and DOB
        /// </summary>
        /// <param name="dateOfBirth"></param>
        /// <param name="lname"></param>
        /// <returns>list of patients based on last name and DOB</returns>
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

        public Boolean DeletePatient(int patientID)
        {
            Boolean success = false;
            int personID;

            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    SqlCommand selectCommand = new SqlCommand("SELECT p.personID FROM person p JOIN patient pa ON pa.personID = p.personID WHERE pa.patientID = @patientID", connection, transaction);
                    selectCommand.Parameters.AddWithValue("@patientID", patientID);
                    personID = (int)selectCommand.ExecuteScalar();
                    

                    SqlCommand deleteCommand = new SqlCommand("DELETE FROM patient WHERE patientID = @patientID", connection, transaction);
                    deleteCommand.Parameters.AddWithValue("@patientId", patientID);
                    deleteCommand.ExecuteNonQuery();

                    deleteCommand = new SqlCommand("DELETE FROM person WHERE personID = @personID", connection, transaction);
                    deleteCommand.Parameters.AddWithValue("@personID", personID);
                    deleteCommand.ExecuteNonQuery();

                    transaction.Commit();
                    success = true;
                }
                catch
                {
                    transaction.Rollback();
                }
            }

            return success;
        }
    }
}
