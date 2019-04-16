using HealthCare.DB;
using HealthCare.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HealthCare.DAL
{
    /// <summary>
    /// Performs all DB sql statements for Appointments
    /// </summary>
    class AppointmentDAL
    {
        /// <summary>
        /// Adds appointment to the database
        /// </summary>
        /// <param name="appointment">appointment to add</param>
        /// <returns></returns>
        public int AddAppointment(Appointment appointment)
        {
            SqlConnection connection = HealthcareDBConnection.GetConnection();
            string insertStatement =
                "INSERT Appointment " +
                  "(patientID, doctorID, dateTime, reasonForVisit) " +
                "VALUES (@patientID, @doctorID, @dateTime, @reasonForVisit)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@patientID", appointment.PatientID);
            insertCommand.Parameters.AddWithValue("@doctorID", appointment.DoctorID);
            insertCommand.Parameters.AddWithValue("@dateTime", appointment.DateTime);
            insertCommand.Parameters.AddWithValue("@reasonForVisit", appointment.ReasonForVisit);
           
            connection.Open();
            insertCommand.ExecuteNonQuery();
            string selectStatement = "SELECT IDENT_CURRENT('Appointment') FROM Appointment";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            int appointmentID = Convert.ToInt32(selectCommand.ExecuteScalar());
            return appointmentID;
        }

        /// <summary>
        /// Gets all the appointments a patient is scheduled for
        /// </summary>
        /// <param name="patientID">patient id for search</param>
        /// <returns></returns>
        public List<Appointment> GetAppointmentsByPatientID(int patientID)
        {
            List<Appointment> appointments = new List<Appointment>();

            string selectStatement =
                "SELECT appointmentID, patientID, doctorID,  dateTime, reasonForVisit " +
                "FROM Appointment " +
                "WHERE patientID = @patientID " +
                "ORDER BY dateTime";
            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@patientID", patientID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Appointment appointment = new Appointment();

                            appointment.AppointmentID = (int)reader["appointmentID"];
                            appointment.PatientID = (int)reader["patientID"];
                            appointment.DoctorID = (int)reader["doctorID"];
                            appointment.DateTime = (DateTime)reader["dateTime"];
                            appointment.ReasonForVisit = (string)reader["reasonForVisit"];

                            appointments.Add(appointment);
                        }
                        
                    }
                }
            }
            return appointments;
        }
    }
}
