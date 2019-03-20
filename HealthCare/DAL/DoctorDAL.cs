using HealthCare.DB;
using HealthCare.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HealthCare.DAL
{
    /// <summary>
    /// Performs all DB sql statements for Doctor
    /// </summary>
    class DoctorDAL
    {
        public List<Doctor> GetDoctors()
        {
            List<Doctor> doctorList = new List<Doctor>();
            string selectStatement =
                "SELECT doctor.doctorID, doctor.personID " +
                "FROM doctor " +
                "JOIN person ON person.personID = doctor.doctorID";

            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Doctor doctor = new Doctor();
                            doctor.DoctorID = (int)reader["doctorID"];
                            doctor.PersonID = (int)reader["personID"];
                            doctorList.Add(doctor);
                        }
                    }
                }
            }
            return doctorList;
        }
    }
}
