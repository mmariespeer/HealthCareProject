using HealthCare.DB;
using HealthCare.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HealthCare.DAL
{
    /// <summary>
    /// Performs all DB sql statements for Doctor
    /// </summary>
    class DoctorDAL
    {
        //Retrieves all doctors in DB
        public List<Doctor> GetDoctors()
        {
            List<Doctor> doctorList = new List<Doctor>();
            string selectStatement =
                "SELECT doctor.doctorID, doctor.personID " +
                "FROM doctor";

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

        //Retrieves doctorID by personID
        public Doctor GetDoctorByPersonID(int personID)
        {
            Doctor doctor = new Doctor();
            string selectStatement =
             "SELECT doctorID, personID " +
             "FROM doctor " +
             "WHERE personID = @personID";
            
            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@personID", personID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            doctor.DoctorID = (int)reader["doctorID"];
                            doctor.PersonID = (int)reader["personID"];
                        }
                    }
                }
            }
            return doctor;
        }

        //Retrieves doctorID by personID
        public bool CheckIfDoctorHasAppointmentScheduled(int doctorID, DateTime dateTime)
        {
            Doctor doctor = new Doctor();
            Appointment appointment = new Appointment();
            string selectStatement =
             "SELECT doctor.doctorID, dateTime " +
             "FROM doctor " +
             "INNER JOIN appointment " +
             "ON appointment.doctorID = doctor.doctorID " +
             "WHERE doctor.doctorID = @doctorID AND dateTime = @dateTime";

            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@doctorID", doctorID);
                    selectCommand.Parameters.AddWithValue("@dateTime", dateTime);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            appointment.DoctorID = (int)reader["doctorID"];
                            appointment.DateTime = (DateTime)reader["dateTime"];
                        }
                    }
                }
                if (appointment.DoctorID == doctorID && appointment.DateTime == dateTime)
                {
                    return true;
                } else
                {
                    return false;
                }
            }
        }
    }
}
