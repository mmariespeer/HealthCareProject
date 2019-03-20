using HealthCare.DB;
using HealthCare.Model;
using System;
using System.Data.SqlClient;

namespace HealthCare.DAL
{
    /// <summary>
    /// Performs all DB sql statements for Appointments
    /// </summary>
    class AppointmentDAL
    {
        //Adds appointment to the database
        public int AddAppointment(Appointment appointment)
        {
            SqlConnection connection = HealthcareDBConnection.GetConnection();
            string insertStatement =
                "INSERT Appointment " +
                  "(appointmentID, patientID, doctorID, dateTime, reasonForVisit) " +
                "VALUES (@appointmentID, @patientID, @doctorID, @dateTime, @reasonForVisit)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@appointmentID", appointment.appointmentID);
            insertCommand.Parameters.AddWithValue("@patientID", appointment.patientID);
            insertCommand.Parameters.AddWithValue("@doctorID", appointment.doctorID);
            insertCommand.Parameters.AddWithValue("@dateTime", appointment.dateTime);
            insertCommand.Parameters.AddWithValue("@reasonForVisit", appointment.reasonForVisit);
           
            connection.Open();
            insertCommand.ExecuteNonQuery();
            string selectStatement = "SELECT IDENT_CURRENT('Appointment') FROM Appointment";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            int appointmentID = Convert.ToInt32(selectCommand.ExecuteScalar());
            return appointmentID;
        }
    }
}
