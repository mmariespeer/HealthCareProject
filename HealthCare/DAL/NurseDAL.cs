using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HealthCare.DB;
using HealthCare.Model;

namespace HealthCare.DAL
{
    class NurseDAL
    {
        /// <summary>
        /// add a new nurse 
        /// </summary>
        /// <param name="person"></param>
        public Boolean addNurse(Person person, String active)
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

                    insertCommand = new SqlCommand("INSERT nurse (personID) VALUES ((SELECT IDENT_CURRENT('person')))", connection, transaction);
                    insertCommand.ExecuteNonQuery();


                    SqlCommand updateCommand = new SqlCommand("UPDATE nurse SET active_status = @active WHERE nurseID = (SELECT IDENT_CURRENT('nurse'))", connection, transaction);
                    updateCommand.Parameters.AddWithValue("@active", active);
                    updateCommand.ExecuteNonQuery();
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
        /// Updates a nurses information
        /// </summary>
        /// <param name="personID"></param>
        /// <param name="lName"></param>
        /// <param name="fName"></param>
        /// <param name="dob"></param>
        /// <param name="streetAddress"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zipCode"></param>
        /// <param name="phone"></param>
        /// <param name="ssn"></param>
        public void UpdateNurse(int personID, string lName, string fName, DateTime dob, string streetAddress,
            string city, string state, int zipCode, string phoneNumber, string ssn, string active)
        {
            string updateStatement = "UPDATE person " +
                                     "SET firstName = @fName, lastName = @lName, dateOfBirth = @dob, " +
                                     "stateCode = @stateCode, streetAddress = @streetAddress, city = @city, " +
                                     "zipCode = @zip, phoneNumber = @phoneNumber, ssn = @ssn " +
                                     "WHERE personID = @pID";
            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    SqlCommand updateCommand = new SqlCommand(updateStatement, connection, transaction);
                    updateCommand.Parameters.AddWithValue("@pID", personID);
                    updateCommand.Parameters.AddWithValue("@lName", lName);
                    updateCommand.Parameters.AddWithValue("@fName", fName);
                    updateCommand.Parameters.AddWithValue("@dob", dob.Date);
                    updateCommand.Parameters.AddWithValue("@streetAddress", streetAddress);
                    updateCommand.Parameters.AddWithValue("@city", city);
                    updateCommand.Parameters.AddWithValue("@stateCode", state);
                    updateCommand.Parameters.AddWithValue("@zip", zipCode);
                    updateCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    updateCommand.Parameters.AddWithValue("@ssn", ssn);

                    updateCommand.ExecuteNonQuery();

                    updateCommand = new SqlCommand("UPDATE nurse SET active_status = @active WHERE personID = @pID", connection, transaction);
                    updateCommand.Parameters.AddWithValue("@active", active);
                    updateCommand.Parameters.AddWithValue("@pID", personID);
                    updateCommand.ExecuteNonQuery();


                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                }

            }
        }

        /// <summary>
        /// returs list of all nurses
        /// </summary>
        /// <returns>list of all nurses</returns>
        public List<Nurse> GetAllNurses()
        {
            List<Nurse> nurseList = new List<Nurse>();

            string selectStatement = "SELECT p.lastName, p.firstName, p.dateOfBirth, n.nurseID FROM person p JOIN nurse n ON p.personID = n.personID";

            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Nurse nurse = new Nurse();
                            nurse.LastName = reader["lastName"].ToString();
                            nurse.FirstName = reader["firstName"].ToString();
                            nurse.DateOfBirth = (DateTime)reader["dateOfBirth"];
                            nurse.NurseID = Convert.ToInt32(reader["nurseID"]);


                            nurseList.Add(nurse);
                        }
                    }
                }
            }
            return nurseList;
        }

        /// <summary>
        /// return whether nurse is active or inactive
        /// </summary>
        /// <param name="nurseID"></param>
        /// <returns>1 for active, 0 for inactive</returns>
        public int GetNurseStatus(int nurseID)
        {
            int active = 0;

            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand("SELECT active_status FROM nurse where nurseID = @id", connection))
                {
                    selectCommand.Parameters.AddWithValue("@id", nurseID);
                    active = Convert.ToInt32(selectCommand.ExecuteScalar());
                }
            }

            return active;
        }
    }
}
