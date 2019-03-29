using HealthCare.DB;
using HealthCare.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HealthCare.DAL
{
    class VisitDAL
    {
        public Visit GetVisitByAppt(int apptID)
        {
            Visit visit = new Visit();

            string selectStatement =
                "SELECT v.*, p.firstName + ' ' + p.lastName AS doctorName, a.patientID, a.datetime, dg.initialDiagnosis, dg.finalDiagnosis " +
                "FROM Visit AS v " +
                "JOIN Appointment AS a ON v.appointmentID = a.appointmentID " +
                "JOIN Doctor AS d ON a.doctorID = d.doctorID " +
                "JOIN Person AS p ON d.personID = p.personID " +
                "JOIN Diagnosis AS dg ON v.visitID = dg.visitID " +
                "WHERE v.appointmentID = @apptID ";

            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@apptID", apptID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            visit.AppointmentID = (int)reader["appointmentID"];
                            visit.PatientID = (int)reader["patientID"];
                            visit.DoctorName = (string)reader["doctorName"];
                            visit.DateTime = (DateTime)reader["dateTime"];
                            visit.Weight = (decimal)reader["weight"];
                            visit.Temp = (decimal)reader["temp"];
                            visit.SystolicBP = (int)reader["systolicBP"];
                            visit.DiastolicBP = (int)reader["diastolicBP"];
                            visit.Symptoms = (string)reader["symptoms"];
                            visit.InitialDiagnosis = (string)reader["initialDiagnosis"];
                            visit.FinalDiagnosis = reader["finalDiagnosis"] as string;
                        }

                    }
                }
            }
            return visit;
        }
    }
}
