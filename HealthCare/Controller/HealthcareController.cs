using HealthCare.DAL;
using HealthCare.Model;
using System.Collections.Generic;

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

        //Initalizes DAL objects
        public HealthcareController()
        {
            appointmentDAL = new AppointmentDAL();
            doctorDAL = new DoctorDAL();
            personDAL = new PersonDAL();
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
    }
}
