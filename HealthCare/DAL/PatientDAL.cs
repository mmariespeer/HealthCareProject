using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
