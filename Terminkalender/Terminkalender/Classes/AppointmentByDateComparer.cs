namespace Terminkalender.Classes
{
    using System.Collections;
    using System.Collections.Generic;

    public class AppointmentByDateComparer : IComparer<Appointment>
    {
        public int Compare(Appointment app1, Appointment app2)
        {
            return app1.TimeOfAppointment.CompareTo(app2.TimeOfAppointment);
        }
    }
}