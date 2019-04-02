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
        #region VisitStatements
        private const string insertVisitStatement = "INSERT INTO visit([nurseID], [appointmentID], [weight], [systolicBP], [diastolicBP], [temp], [pulse], [symptoms])" +
                        "VALUES(@nurseID,@apptID,@weight,@systolicBP,@diastolicBP,@temp,1,@symptoms); SELECT SCOPE_IDENTITY()";
        private const string insertDiagnosticStatement = "INSERT INTO diagnosis([visitID],[initialDiagnosis],[finalDiagnosis])" +
                        "VALUES(@visitID,@initial,@final)";
        private const string updateVisitStatement = "UPDATE visit SET [nurseID] = @nurseID, [appointmentID] = @apptID, [weight] = @weight, [systolicBP] = @systolicBP, [diastolicBP] = @diastolicBP"+
            ", [temp] = @temp ,[pulse] = 1 ,[symptoms] = @symptoms " +
            "WHERE visitID = @visitID";
        private const string updateDiagnosticsStatement = "UPDATE diagnosis SET [visitID] = @visitID, [initialDiagnosis] = @initial, [finalDiagnosis] = @final WHERE visitID = @visitID";

        #endregion

        private const string selectStatement = "SELECT p.firstName + ' ' + p.lastName AS doctorName, a.patientID, a.datetime, dg.initialDiagnosis, dg.finalDiagnosis, v.weight, v.systolicBP, v.diastolicBP, v.temp, v.pulse, v.symptoms, v.visitID, a.appointmentID " +
                "FROM Appointment AS a " +
                "LEFT JOIN Visit AS v ON v.appointmentID = a.appointmentID " +
                "JOIN Doctor AS d ON a.doctorID = d.doctorID " +
                "JOIN Person AS p ON d.personID = p.personID " +
                "LEFT JOIN Diagnosis AS dg ON v.visitID = dg.visitID " +
                "WHERE a.appointmentID = @apptID ";

        public Visit GetVisitByAppt(int apptID)
        {
            Visit visit = new Visit();

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
                            visit.VisitID = reader["visitID"] as int? ?? 0;
                            visit.AppointmentID = (int)reader["appointmentID"];
                            visit.PatientID = (int)reader["patientID"];
                            visit.DoctorName = (string)reader["doctorName"];
                            visit.DateTime = (DateTime)reader["dateTime"];
                            visit.Weight = reader["weight"] as decimal? ?? 0;
                            visit.Temp = reader["temp"] as decimal? ?? 0;
                            visit.SystolicBP = reader["systolicBP"] as int? ?? 0;
                            visit.DiastolicBP = reader["diastolicBP"] as int? ?? 0;
                            visit.Symptoms = reader["symptoms"] as string;
                            visit.InitialDiagnosis = reader["initialDiagnosis"] as string;
                            visit.FinalDiagnosis = reader["finalDiagnosis"] as string;
                        }

                    }
                }
            }
            return visit;
        }

        public List<Test> GetTestsByVisitId(int visitId)
        {
            List<Test> testList = new List<Test>();

            string selectStatement =
                "SELECT t.testName, tr.testCode, tr.results, tr.normal, tr.testDate " +
                "FROM testResult AS tr " +
                "JOIN test AS t ON tr.testCode = t.testCode " +
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

        public bool AddOrUpdateVisit(Visit visit)
        {
            int visitResult=0;
            int diagnosisResult=0;

            if (visit.VisitID == 0)
            {
                //create new visit
                using (SqlConnection connection = HealthcareDBConnection.GetConnection())
                {
                    int pk = -1;
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    try
                    {
                        using (SqlCommand insertCommand = new SqlCommand(insertVisitStatement, connection))
                        {
                            insertCommand.Transaction = transaction;
                            insertCommand.Parameters.AddWithValue("@nurseID", visit.NurseID);
                            insertCommand.Parameters.AddWithValue("@apptID", visit.AppointmentID);
                            insertCommand.Parameters.AddWithValue("@weight", visit.Weight);
                            insertCommand.Parameters.AddWithValue("@systolicBP", visit.SystolicBP);
                            insertCommand.Parameters.AddWithValue("@diastolicBP", visit.DiastolicBP);
                            insertCommand.Parameters.AddWithValue("@temp", visit.Temp);
                            insertCommand.Parameters.AddWithValue("@symptoms", visit.Symptoms);

                            
                            pk = Convert.ToInt32(insertCommand.ExecuteScalar());
                            visitResult = 1;
                        }
                        using (SqlCommand insertDiagnosisCommand = new SqlCommand(insertDiagnosticStatement, connection))
                        {
                            insertDiagnosisCommand.Transaction = transaction;
                            insertDiagnosisCommand.Parameters.AddWithValue("@visitID", pk);
                            insertDiagnosisCommand.Parameters.AddWithValue("@initial", visit.InitialDiagnosis);
                            insertDiagnosisCommand.Parameters.AddWithValue("@final", visit.FinalDiagnosis);

                            diagnosisResult = insertDiagnosisCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                    }
                }
            }
            else
            {
                //update visit and diagnostics
                using (SqlConnection connection = HealthcareDBConnection.GetConnection())
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    try
                    {
                        using (SqlCommand updateVisitCommand = new SqlCommand(updateVisitStatement, connection))
                        {
                            updateVisitCommand.Transaction = transaction;
                            updateVisitCommand.Parameters.AddWithValue("@nurseID", visit.NurseID);
                            updateVisitCommand.Parameters.AddWithValue("@apptID", visit.AppointmentID);
                            updateVisitCommand.Parameters.AddWithValue("@weight", visit.Weight);
                            updateVisitCommand.Parameters.AddWithValue("@systolicBP", visit.SystolicBP);
                            updateVisitCommand.Parameters.AddWithValue("@diastolicBP", visit.DiastolicBP);
                            updateVisitCommand.Parameters.AddWithValue("@temp", visit.Temp);
                            updateVisitCommand.Parameters.AddWithValue("@symptoms", visit.Symptoms);
                            updateVisitCommand.Parameters.AddWithValue("@visitID", visit.VisitID);

                            visitResult = updateVisitCommand.ExecuteNonQuery();
                        }
                        using (SqlCommand updateDiagnositicsCommand = new SqlCommand(updateDiagnosticsStatement, connection))
                        {
                            updateDiagnositicsCommand.Transaction = transaction;
                            updateDiagnositicsCommand.Parameters.AddWithValue("@visitID", visit.VisitID);
                            updateDiagnositicsCommand.Parameters.AddWithValue("@initial", visit.InitialDiagnosis);
                            updateDiagnositicsCommand.Parameters.AddWithValue("@final", visit.FinalDiagnosis);     

                            diagnosisResult = updateDiagnositicsCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                    }
                }

            }
            return (diagnosisResult == 1 && visitResult >= 1 ? true : false);
        }
    }
}
