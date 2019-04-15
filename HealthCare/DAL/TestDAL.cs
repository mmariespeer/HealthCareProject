using HealthCare.DB;
using HealthCare.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.DAL
{
    class TestDAL
    {

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
                            test.Results = reader["results"] as string;
                            test.Normal = reader["normal"] as bool?;
                            test.TestDate = (DateTime)reader["testDate"];
                            test.VisitId = visitId;
                            testList.Add(test);
                        }
                    }
                }
            }
            return testList;
        }

        public List<Test> GetAllTests()
        {
            List<Test> testList = new List<Test>();

            string selectStatement =
                "SELECT * " +
                "FROM test ";

            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Test test = new Test();

                            test.TestCode = (string)reader["testCode"];
                            test.TestName = (string)reader["testName"];
                            testList.Add(test);
                        }
                    }
                }
            }
            return testList;
        }

        public void OrderTest(Test testToOrder)
        {
            string insertStatement = "INSERT INTO testResult(visitID,testCode,testDate,results,normal)VALUES(@visitID,@testCode,@testDate,@results,@normal);";
            string values = string.Empty;
            DateTime now = DateTime.Now;

            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();             

                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Transaction = connection.BeginTransaction();
                    insertCommand.Parameters.AddWithValue("@visitID", testToOrder.VisitId);
                    insertCommand.Parameters.AddWithValue("@testCode", testToOrder.TestCode);
                    insertCommand.Parameters.AddWithValue("@testDate", now);
                    insertCommand.Parameters.AddWithValue("@results", DBNull.Value);
                    insertCommand.Parameters.AddWithValue("@normal", DBNull.Value);
                    insertCommand.ExecuteNonQuery();

                    insertCommand.Transaction.Commit();
                }
            }
        }
    }
}
