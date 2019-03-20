using HealthCare.DAL;
using HealthCare.Model;

namespace HealthCare.Controller
{
    /// <summary>
    /// Controls all the data of the DALS to be used in the View
    /// </summary>
    class HealthcareController
    {
        private AppointmentDAL appointmentDAL;

        //Initalizes DAL objects
        public HealthcareController()
        {
            appointmentDAL = new AppointmentDAL();
        }

        //Adds a new appointment to the DB
        public void AddAppointment(Appointment appointment)
        {
            appointmentDAL.AddAppointment(appointment);
        }
    }
}
