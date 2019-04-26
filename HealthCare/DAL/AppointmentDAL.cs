using HealthCare.DB;
using HealthCare.Model;
using System;
using System.Collections.Generic;
using System.Data;
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

        /// <summary>
        /// Gets an appointment with the doctor displayed and returns a datatable.
        /// </summary>
        /// <param name="patientID"></param>
        /// <returns></returns>
        public DataTable GetAppointmentsAndDoctorByPatientID(int patientID)
        {

            DataTable dataTable = new DataTable();
            string selectStatement =
                "SELECT appointmentID AS AppointmentID, patientID AS PatientID, person.lastName AS Doctor,  dateTime AS 'Appointment Time', reasonForVisit AS Reason " +
                "FROM Appointment " +
                "JOIN Doctor ON Doctor.doctorID = appointment.doctorID " +
                "JOIN Person ON Person.personID = Doctor.personID " +
                "WHERE patientID = @patientID " +
                "ORDER BY dateTime";
            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@patientID", patientID);
                    dataTable.Load(selectCommand.ExecuteReader());

                }
            }
            return dataTable;
        }

        public void UpdateAppointment(Appointment appointment)
        {
            string updateStatement = "UPDATE appointment " +
                                     "SET reasonForVisit = @reason, doctorID = @docID, dateTime = @datetime " +
                                     "WHERE appointmentID = @appmtID";
            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();

                SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
                updateCommand.Parameters.AddWithValue("@reason", appointment.ReasonForVisit);
                updateCommand.Parameters.AddWithValue("@docID", appointment.DoctorID);
                updateCommand.Parameters.AddWithValue("@dateTime", appointment.DateTime);
                updateCommand.Parameters.AddWithValue("@appmtID", appointment.AppointmentID);

                updateCommand.ExecuteNonQuery();
            }
        }

        public Appointment GetAppointmentByAppointmentID(int appointmentID)
        {
            Appointment appointment = new Appointment();

            string selectStatement =
                "SELECT a.appointmentID, a.patientID, (p.firstName + ' ' + p.lastName) AS name, a.dateTime, a.reasonForVisit FROM Appointment a JOIN doctor d" +
                " ON a.doctorID = d.doctorID JOIN person p ON p.personID = d.personID WHERE appointmentID = @appmtID";

            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@appmtID", appointmentID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            appointment.AppointmentID = (int)reader["appointmentID"];
                            appointment.PatientID = (int)reader["patientID"];
                            appointment.DoctorName = reader["name"].ToString();
                            appointment.DateTime = (DateTime)reader["dateTime"];
                            appointment.ReasonForVisit = (string)reader["reasonForVisit"];
                        }
                    }
                }
            }
            return appointment;
        }
    }
}
