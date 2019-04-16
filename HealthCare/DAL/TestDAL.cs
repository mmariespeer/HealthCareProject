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
    //The test data access layer
    class TestDAL
    {
        /// <summary>
        /// Get specific test's assigned to a visit
        /// </summary>
        /// <param name="visitId">as an integer</param>
        /// <returns>a list of tests</returns>
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

        /// <summary>
        /// Update an existing test
        /// </summary>
        /// <param name="visitID">visitid as an integer</param>
        /// <param name="testCode">the test code as string</param>
        /// <param name="result">as string</param>
        /// <param name="normal">as bool</param>

        public void UpdateTestResult(int visitID, string testCode, string result, bool normal)
        {
            string updateStatement = "UPDATE testResult SET results = @result, normal = @normal WHERE visitID = @visitID AND testCode = @testCode;";
            DateTime now = DateTime.Now;

            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Transaction = connection.BeginTransaction();
                    updateCommand.Parameters.AddWithValue("@visitID", visitID);
                    updateCommand.Parameters.AddWithValue("@testCode", testCode);
                    updateCommand.Parameters.AddWithValue("@result", result);
                    updateCommand.Parameters.AddWithValue("@normal", normal);

                    updateCommand.ExecuteNonQuery();

                    updateCommand.Transaction.Commit();
                }
            }
        }

        /// <summary>
        /// Get all available tests
        /// </summary>
        /// <returns>A list of all available tests</returns>
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

        /// <summary>
        /// Insert a new test into the test result table indicating it has been ordered
        /// </summary>
        /// <param name="testToOrder"> the test to be ordered</param>
        public void OrderTest(Test testToOrder)
        {
            string insertStatement = "INSERT INTO testResult(visitID,testCode,testDate,results,normal)VALUES(@visitID,@testCode,@testDate,@results,@normal);";
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
