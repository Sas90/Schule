namespace Terminkalender.Classes
{
    using System;
    using System.Collections.Generic;

    public class AppointmentByPersonComparer : IComparer<Appointment>
    {
        public int Compare(Appointment app1, Appointment app2)
        {
            return string.Compare(app1.PersonOfAppointment.LastName, app2.PersonOfAppointment.LastName, StringComparison.InvariantCulture);
        }
    }
}