using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
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
        public void addNurse(Person person)
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

                    insertCommand = new SqlCommand("INSERT nurse (personID) VALUES ((SELECT IDENT_CURRENT('person')))", connection, transaction);
                    insertCommand.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("New Nurse Added");
                }
                catch
                {
                    transaction.Rollback();
                    MessageBox.Show("ghj");

                }
            }
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
            string city, string state, int zipCode, string phoneNumber, string ssn)
        {
            string updateStatement = "UPDATE person " +
                                     "SET firstName = @fName, lastName = @lName, dateOfBirth = @dob, " +
                                     "stateCode = @stateCode, streetAddress = @streetAddress, city = @city, " +
                                     "zipCode = @zip, phoneNumber = @phoneNumber, ssn = @ssn " +
                                     "WHERE personID = @pID";
            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("@pID", personID);
                    updateCommand.Parameters.AddWithValue("@lName", lName);
                    updateCommand.Parameters.AddWithValue("@fName", fName);
                    updateCommand.Parameters.AddWithValue("@dob", dob);
                    updateCommand.Parameters.AddWithValue("@streetAddress", streetAddress);
                    updateCommand.Parameters.AddWithValue("@city", city);
                    updateCommand.Parameters.AddWithValue("@stateCode", state);
                    updateCommand.Parameters.AddWithValue("@zip", zipCode);
                    updateCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    updateCommand.Parameters.AddWithValue("@ssn", ssn);
                    updateCommand.ExecuteNonQuery();
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
    }
}
