namespace Terminkalender.Classes
{
    using System;

    public class Appointment
    {
        public Appointment(Person person, Location location, DateTime timeOfAppointment, string description)
        {
            TimeOfAppointment = timeOfAppointment;
            PersonOfAppointment = person;
            LocationOfAppointment = location;
            Description = description;
        }

        public Person PersonOfAppointment { get; set; }

        public Location LocationOfAppointment { get; set; }

        public DateTime TimeOfAppointment { get; set; }

        public string Description { get; set; }

        public void Clone(Appointment appointment)
        {
            PersonOfAppointment = appointment.PersonOfAppointment;
            LocationOfAppointment = appointment.LocationOfAppointment;
            TimeOfAppointment = appointment.TimeOfAppointment;
            Description = appointment.Description;
        }
    }
}