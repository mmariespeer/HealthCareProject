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

        //Initalizes DAL objects
        public HealthcareController()
        {
            appointmentDAL = new AppointmentDAL();
            doctorDAL = new DoctorDAL();
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
    }
}
