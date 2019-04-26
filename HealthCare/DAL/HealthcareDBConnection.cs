using System.Data.SqlClient;

namespace HealthCare.DB
{
    /// <summary>
    /// Sets up connection to healthcare database (cs6232-g2) on local machine
    /// </summary>
    class HealthcareDBConnection
    {
        /// <summary>
        /// Get the connection to/for the db
        /// </summary>
        /// <returns>A sql connection</returns>
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost;Initial Catalog=cs6232-g2;" +
                "Integrated Security=True; Column Encryption Setting=Enabled";


            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }
    }
}
