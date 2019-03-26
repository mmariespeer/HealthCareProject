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
    public class SearchPatientDAL
    {
        public void GetAllPatients()
        {
            List<Person> allPatients = new List<Person>();
            string selectStatement = "SELECT DISTINCT t.TechID, t.Name, t.Email, t.Phone FROM Technicians t JOIN Incidents i ON t.TechID = i.TechID WHERE i.TechID IS NOT NULL;";

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
                           Person patient = new Person();
                            patient.LastName = reader["Name"].ToString();
                            patient.FirstName = reader["Email"].ToString();
                           // patient.DateOfBirth = reader["Phone"].ToString();

                            allPatients.Add(patient);
                        }
                    }


                }

            }

            //return allPatients;
        }
    }
}
