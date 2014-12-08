namespace Terminkalender.Classes
{
    using System;
    using System.Collections.Generic;

    internal class AppointmentByDescriptionComparer : IComparer<Appointment>
    {
        public int Compare(Appointment app1, Appointment app2)
        {
            return string.Compare(app1.Description, app2.Description, StringComparison.InvariantCulture);
        }
    }
}