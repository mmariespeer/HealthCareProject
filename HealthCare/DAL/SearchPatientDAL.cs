using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HealthCare.DB;
using HealthCare.Model;

namespace HealthCare.DAL
{
    class SearchPatientDAL
    {
        /// <summary>
        /// return a list of all current patients
        /// </summary>
        /// <returns>list of all current patients</returns>
        public List<Patient> GetAllPatients() 
        {
            List<Patient> allPatients = new List<Patient>();
            string selectStatement = "SELECT (p.firstName + ' ' + p.lastname) AS Name, p.lastname, p.dateOfBirth, pa.personID, pa.patientID FROM person p JOIN patient pa ON p.personID = pa.personID ORDER BY Name ASC"; 

            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();

                SqlCommand sc = new SqlCommand(selectStatement, connection);
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                           Patient patient = new Patient();
                            patient.LastName = reader["lastName"].ToString();
                            patient.PatientID = Convert.ToInt32(reader["patientID"]);
                            patient.FullName = reader["Name"].ToString();
                            patient.DateOfBirth = (DateTime)reader["dateOfBirth"];
                            patient.PersonID = Convert.ToInt32(reader["personID"]);

                            allPatients.Add(patient);
                        }
                    }


                }

            }

            return allPatients;
        }

        /// <summary>
        /// return a patient based on personID
        /// </summary>
        /// <param name="personID"></param>
        /// <returns>a patient based on personID</returns>
        public List<SearchPatient> GetSelectedPatients(int personID)
        {
            List<SearchPatient> searchList = new List<SearchPatient>();

            string selectStatement = "SELECT p.lastName, p.firstName, p.dateOfBirth, pa.patientID FROM person p JOIN patient pa ON p.personID = pa.personID WHERE p.personID = @personID";

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
                            SearchPatient patient = new SearchPatient();
                            patient.LastName = reader["lastName"].ToString();
                            patient.FirstName = reader["firstName"].ToString();
                            patient.DateOfBirth = (DateTime)reader["dateOfBirth"];
                            patient.PatientID = Convert.ToInt32(reader["patientID"]);


                            searchList.Add(patient);
                        }
                    }
                }
            }

            return searchList;
        }

        /// <summary>
        /// return a list of patients by last name
        /// </summary>
        /// <param name="lname"></param>
        /// <returns>list of patients searched by last name</returns>
        public List<SearchPatient> GetPatientsByLastName(string lname)
        {
            List<SearchPatient> searchList = new List<SearchPatient>();

            string selectStatement = "SELECT p.lastName, p.firstName, p.dateOfBirth, pa.patientID FROM person p JOIN patient pa ON p.personID = pa.personID WHERE p.lastName = @lname";

            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@lname", lname);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SearchPatient patient = new SearchPatient();
                            patient.LastName = reader["lastName"].ToString();
                            patient.FirstName = reader["firstName"].ToString();
                            patient.DateOfBirth = (DateTime)reader["dateOfBirth"];
                            patient.PatientID = Convert.ToInt32(reader["patientID"]);


                            searchList.Add(patient);
                        }
                    }
                }
            }

            return searchList;
        }

        /// <summary>
        /// return a list of patients by date of birth
        /// </summary>
        /// <param name="dob"></param>
        /// <returns>list of patients searched by date of birth</returns>
        public List<SearchPatient> GetPatientsByDOB(DateTime dob)
        {
            List<SearchPatient> searchList = new List<SearchPatient>();

            string selectStatement = "SELECT p.lastName, p.firstName, p.dateOfBirth, pa.patientID FROM person p JOIN patient pa ON p.personID = pa.personID WHERE CAST(p.dateOfBirth as DATE) = @DOB";

            using (SqlConnection connection = HealthcareDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@DOB", dob.ToString("yyyy-MM-dd"));

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SearchPatient patient = new SearchPatient();
                            patient.LastName = reader["lastName"].ToString();
                            patient.FirstName = reader["firstName"].ToString();
                            patient.DateOfBirth = (DateTime)reader["dateOfBirth"];
                            patient.PatientID = Convert.ToInt32(reader["patientID"]);


                            searchList.Add(patient);
                        }
                    }
                }
            }

            return searchList;
        }
    }
}
