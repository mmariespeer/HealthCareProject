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
        private VisitDAL visitDAL;
        private AppointmentDAL appointmentDAL;
        private DoctorDAL doctorDAL;
        private PersonDAL personDAL;
        private LoginDAL loginDAL;
        private PatientDAL patientDAL;
        private NurseDAL nurseDAL;
        private TestDAL testDAL;

        /// <summary>
        /// Initalizes DAL objects
        /// </summary>
        public HealthcareController()
        {
            visitDAL = new VisitDAL();
            appointmentDAL = new AppointmentDAL();
            doctorDAL = new DoctorDAL();
            personDAL = new PersonDAL();
            loginDAL = new LoginDAL();
            patientDAL = new PatientDAL();
            nurseDAL = new NurseDAL();
            testDAL = new TestDAL();
        }

        public void UpdateTestResult(int visitID, string testCode, string result, bool normal)
        {
            testDAL.UpdateTestResult(visitID, testCode, result, normal);
        }

        /// <summary>
        /// Adds a new appointment to the DB
        /// </summary>
        /// <param name="appointment">appointment to add</param>
        public void AddAppointment(Appointment appointment)
        {
            appointmentDAL.AddAppointment(appointment);
        }

        /// <summary>
        /// Gets all the doctors available
        /// </summary>
        /// <returns>List of doctors</returns>
        public List<Doctor> GetDoctors()
        {
            return doctorDAL.GetDoctors();
        }

        /// <summary>
        /// Get a person by their personID
        /// </summary>
        /// <param name="personID">person ID to search</param>
        /// <returns>Person of that ID</returns>
        public Person GetPeronById(int personID)
        {
            return personDAL.GetPersonByID(personID);
        }

        /// <summary>
        /// Get a doctor by their personID
        /// </summary>
        /// <param name="personID">person ID to search</param>
        /// <returns>Doctor of that Person ID</returns>
        public Doctor GetDoctorByPersonID(int personID)
        {
            return doctorDAL.GetDoctorByPersonID(personID);
        }

        /// <summary>
        /// Retrieves list of appointments by patient ID
        /// </summary>
        /// <param name="patientID">Patient ID to search</param>
        /// <returns>List of appointments for that patient ID</returns>
        public List<Appointment> GetAppointmentsByPatientID(int patientID)
        {
            return appointmentDAL.GetAppointmentsByPatientID(patientID);
        }

        /// <summary>
        /// Checks if the doctor already has an appointment scheduled at that time.
        /// </summary>
        /// <param name="doctorID">Doctor ID to search</param>
        /// <param name="dateTime">date/time to search</param>
        /// <returns>True if doctor is scheduled</returns>
        public bool CheckIfDoctorHasAppointmentScheduled(int doctorID, DateTime dateTime)
        {
            return doctorDAL.CheckIfDoctorHasAppointmentScheduled(doctorID, dateTime);
        }

        /// <summary>
        /// Gets a person by the doctorID
        /// </summary>
        /// <param name="docID">Doctor ID to search</param>
        /// <returns>Peson with that DoctorID</returns>
        public Person GetPersonByDoctorID(int docID)
        {
            return this.personDAL.GetPersonByDoctorID(docID);
        }

        /// <summary>
        /// Gets a person by the patientID
        /// </summary>
        /// <param name="patientID">patient ID to search</param>
        /// <returns>Person with that patient ID</returns>
        public Person GetPersonByPatientID(int patientID)
        {
            return this.personDAL.GetPersonByPatientID(patientID);
        }

        /// <summary>
        /// Get a patient using their full name
        /// </summary>
        /// <param name="fname">firat name as a string</param>
        /// <param name="lname">last name as a string</param>
        /// <returns>a list of patients</returns>
        public List<Patient> GetPatientsByFullName(string fname, string lname)
        {
            return this.patientDAL.GetPatientsByFullName(fname, lname);
        }

        /// <summary>
        /// Get patients using their date of birth and lastname
        /// </summary>
        /// <param name="dateOfBirth">as a datetime</param>
        /// <param name="lname">last name as a string</param>
        /// <returns></returns>
        public List<Patient> GetPatientsByDOBandLastName(DateTime dateOfBirth, string lname)
        {
            return this.patientDAL.GetPatientsByDOBandLastName(dateOfBirth, lname);
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
        /// Add or update a visit
        /// </summary>
        /// <param name="visit">a visit object to be inserted or updated</param>
        /// <returns>a true or false value based on successs</returns>
        public bool AddVisit(Visit visit)
        {
            Visit existingVisit = visitDAL.GetVisitByAppt(visit.AppointmentID);
            if(existingVisit != null)
            {
                visit.VisitID = existingVisit.VisitID;
            }
            return this.visitDAL.AddOrUpdateVisit(visit);
        }

        /// <summary>
        /// return a list of patients by date of birth
        /// </summary>
        /// <param name="dob"></param>
        /// <returns>list of patients searched by date of birth</returns>
        public List<Patient> GetPatientsByDOB(DateTime dob)
        {
            return this.patientDAL.GetPatientsByDOB(dob);
        }

        /// <summary>
        /// Get a single visit from the visit DAL layer
        /// </summary>
        /// <param name="apptID">the appt associated with the visit</param>
        /// <returns>A visit object</returns>
        public Visit GetVisitByAppointmentID(int apptID)
        {
            return this.visitDAL.GetVisitByAppt(apptID);
        }

        /// <summary>
        /// return a list of test by visit id
        /// </summary>
        /// <param name="visitId"></param>
        /// <returns>a list of tests</returns>
        public List<Test> GetTestsByVisitId(int visitId)
        {
            return testDAL.GetTestsByVisitId(visitId);
        }

        public List<Test> GetAllTests()
        {
            return testDAL.GetAllTests();
        }

        public void OrderTest(Test testToOrder)
        {
            testDAL.OrderTest(testToOrder);
        }

        /// <summary>
        /// add a new patient
        /// </summary>
        /// <param name="person"></param>
        public void registerPatient(Person person)
        {
            this.patientDAL.registerPatient(person);
        }

        /// <summary>
        /// return a list of all states
        /// </summary>
        /// <returns>list of all states</returns>
        public List<State> GetAllStates()
        {
            return this.patientDAL.GetAllStates();
        }

        /// <summary>
        /// return a state's name by its state code
        /// </summary>
        /// <param name="stateCode"></param>
        /// <returns>a state's name</returns>
        public String findStateNamebyCode(string stateCode)
        {
            return this.patientDAL.findStateNamebyCode(stateCode);
        }

        /// <summary>
        /// update a patient's information
        /// </summary>
        /// <param name="personID"></param>
        /// <param name="lastName"></param>
        /// <param name="zipCode"></param>
        /// <param name="firstName"></param>
        /// <param name="street"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="phone"></param>
        public void updatePatient(int personID, string lastName, int zipCode, string firstName, string street, string city, string state, string phone)
        {
            this.patientDAL.updatePatient(personID, lastName, zipCode, firstName, street, city, state, phone);
        }

        /// <summary>
        /// Adds a nurse
        /// </summary>
        /// <param name="person"></param>
        public void addNurse(Person person)
        {
            this.nurseDAL.addNurse(person);
        }

        /// <summary>
        /// Updates a nurses information
        /// </summary>
        /// <param name="personID"></param>
        /// <param name="lName"></param>
        /// <param name="fName"></param>
        /// <param name="dob"></param>
        /// <param name="streetAddress"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zipCode"></param>
        /// <param name="phone"></param>
        /// <param name="ssn"></param>
        public void UpdateNuse(int personID, string lName, string fName, DateTime dob, 
            string streetAddress, string city, string state, int zipCode, string phone, int ssn)
        {
            this.nurseDAL.UpdateNurse(personID, lName, fName, dob, streetAddress, city, state, zipCode, phone, ssn);
        }

        /// <summary>
        /// return list of all nurses
        /// </summary>
        /// <returns>list of all nurses</returns>
        public List<Nurse> GetAllNurses()
        {
            return this.nurseDAL.GetAllNurses();
        }

        /// <summary>
        /// Gets a person by the nurseID
        /// </summary>
        /// <param name="nurseID">nurse ID to search</param>
        /// <returns>Person with that nurse ID</returns>
        public Person GetPersonByNurseID(int nurseID)
        {
            return this.personDAL.GetPersonByNurseID(nurseID);
        }
    }
}
