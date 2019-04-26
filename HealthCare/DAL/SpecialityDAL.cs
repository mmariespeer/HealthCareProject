using HealthCare.DB;
using HealthCare.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HealthCare.DAL
{
    /// <summary>
    /// Specialty class data access layer
    /// </summary>
    class SpecialityDAL
    {

        /// <summary>
        /// Returns all the specialties of a doctor
        /// </summary>
        /// <param name="docID"></param>
        /// <returns></returns>
        public List<Specialty> GetSpecialtyByDoctorID(int docID)
        {
            List<Specialty> specialties = new List<Specialty>();
            string selectStatement =
                "SELECT specialtyName " +
                "FROM specialty " +
                "INNER JOIN Doctor " +
                "ON Doctor.DoctorID = Specialty.DoctorID " +
                "WHERE Doctor.doctorID = @docID";

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
                            Specialty specialty = new Specialty();
                            specialty.SpecialityName = reader["specialtyName"].ToString();

                            specialties.Add(specialty);
                        }
                    }
                }
                return specialties;
            }
        }
    }
}
