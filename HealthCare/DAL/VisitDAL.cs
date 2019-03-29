using HealthCare.DB;
using HealthCare.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;

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
                            visit.VisitID = (int)reader["visitID"];
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

        public List<Test> GetTestsByVisitId(int visitId)
        {
            Debug.WriteLine("we get to the sql with " + visitId);
            List<Test> testList = new List<Test>();

            string selectStatement =
                "SELECT t.testName, tr.testCode, tr.results, tr.normal, tr.testDate " +
                "FROM testResult AS tr " +
                "JOIN test AS t ON tr.testCode = t.testCode "+
                "WHERE tr.visitID = @visitID";

            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@visitID", visitId);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Test test = new Test();

                            test.TestCode = (string)reader["testCode"];
                            test.TestName = (string)reader["testName"];
                            test.Results = (string)reader["results"];
                            test.Normal = reader["normal"] as bool?;
                            test.TestDate = (DateTime)reader["testDate"];

                            testList.Add(test);
                        }

                    }
                }
            }
            return testList;
        }
    }
}
