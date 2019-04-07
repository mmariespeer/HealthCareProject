using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    MessageBox.Show("no double ssn");

                }
            }

        }
    }
}
