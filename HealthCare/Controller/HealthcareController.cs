using HealthCare.DAL;
using HealthCare.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace HealthCare.Controller
{
    /// <summary>
    /// Controls all the data of the DALS to be used in the View
    /// </summary>
    class HealthcareController
    {
        private AppointmentDAL appointmentDAL;
        private DoctorDAL doctorDAL;
        private PersonDAL personDAL;
        private LoginDAL loginDAL;
        private SearchPatientDAL searchDAL;

        //Initalizes DAL objects
        public HealthcareController()
        {
            appointmentDAL = new AppointmentDAL();
            doctorDAL = new DoctorDAL();
            personDAL = new PersonDAL();
            loginDAL = new LoginDAL();
            searchDAL = new SearchPatientDAL();
        }

        //Adds a new appointment to the DB
        public void AddAppointment(Appointment appointment)
        {
            appointmentDAL.AddAppointment(appointment);
        }

        //Gets all the doctors available
        public List<Doctor> GetDoctors()
        {
            return doctorDAL.GetDoctors();
        }

        //Get a person by their personID
        public Person GetPeronById(int personID)
        {
            return personDAL.GetPersonByID(personID);
        }

        //Get a doctor by their personID
        public Doctor GetDoctorByPersonID(int personID)
        {
            return doctorDAL.GetDoctorByPersonID(personID);
        }

        /// <summary>
        /// retrieve a person's login information
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>a person's id, username and password</returns>
        public DataTable getLogin(string username, string password)
        {
            return loginDAL.getLogin(username, password);
        }

        /// <summary>
        /// return true if user is a nurse
        /// </summary>
        /// <param name="personID"></param>
        /// <returns>true if user is a nurse</returns>
        public Boolean isNurse(int personID)
        {
            return loginDAL.isNurse(personID);
        }

        /// <summary>
        /// return a list of all current patients
        /// </summary>
        /// <returns>list of all current patients</returns>
        public List<Patient> GetAllPatients()
        {
            return this.searchDAL.GetAllPatients();
        }

        /// <summary>
        /// return a patient based on personID
        /// </summary>
        /// <param name="personID"></param>
        /// <returns>a patient based on personID</returns>
        public List<SearchPatient> GetSelectedPatients(int personID)
        {
            return this.searchDAL.GetSelectedPatients(personID);
        }

        /// <summary>
        /// return a list of patients by last name
        /// </summary>
        /// <param name="lname"></param>
        /// <returns>list of patients searched by last name</returns>
        public List<SearchPatient> GetPatientsByLastName(string lname)
        {
            return this.searchDAL.GetPatientsByLastName(lname);
        }

        /// <summary>
        /// return a list of patients by date of birth
        /// </summary>
        /// <param name="dob"></param>
        /// <returns>list of patients searched by date of birth</returns>
        public List<SearchPatient> GetPatientsByDOB(DateTime dob)
        {
            return this.searchDAL.GetPatientsByDOB(dob);
        }
    }
}
