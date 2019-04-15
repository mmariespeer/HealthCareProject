using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using HealthCare.DB;
using HealthCare.Model;

namespace HealthCare.DAL
{
    public class LoginDAL
    {
        /// <summary>
        /// retireve a person's login information
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public DataTable getLogin(string username, string password)
        {
            DataTable dt = new DataTable();
            string selectStatement = "SELECT l.personID, l.userName, l.password, (p.firstName + ' ' + p.lastName) AS name" +
                " FROM login l JOIN person p ON p.personID = l.personID WHERE userName = @username AND password = @password";

            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();
                SqlCommand sc = new SqlCommand(selectStatement, connection);
                sc.Parameters.AddWithValue("@username", username);

                SqlParameter passwordParam = new SqlParameter("password", SqlDbType.VarChar, 50);
                passwordParam.Value = password;
                sc.Parameters.Add(passwordParam);

                SqlDataReader reader = sc.ExecuteReader();


                dt.Columns.Add("personID", typeof(int));
                dt.Columns.Add("userName", typeof(string));
                dt.Columns.Add("password", typeof(string));
                dt.Columns.Add("name", typeof(string));


                dt.Load(reader);

            }

            return dt;
        }

        /// <summary>
        /// return true if user is a nurse
        /// </summary>
        /// <param name="personID"></param>
        /// <returns>true if user is a nurse</returns>
        public Boolean isNurse (int personID)
        {
            DataTable dt = new DataTable();
            Boolean isNurse = false;
            string selectStatement = "SELECT CASE WHEN EXISTS(SELECT * FROM nurse n WHERE n.personID = p.personID)" + 
                " THEN 'is nurse' ELSE 'not nurse' END FROM person p WHERE p.personID = @personID";

            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();

                SqlCommand sc = new SqlCommand(selectStatement, connection);
                sc.Parameters.AddWithValue("@personID", personID);

               using (SqlDataReader reader = sc.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.GetValue(0).ToString() == "is nurse")
                        {
                            isNurse = true;
                        }
                    }
                }

                return isNurse;
              
            }
        }



    }
}
