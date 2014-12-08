namespace Terminkalender.Classes
{
    using System;
    using System.Collections.Generic;

    public class AppointmentByLocationComparer : IComparer<Appointment>
    {
        public int Compare(Appointment app1, Appointment app2)
        {
            return string.Compare(app1.LocationOfAppointment.Name, app2.LocationOfAppointment.Name, StringComparison.InvariantCulture);
        }
    }
}