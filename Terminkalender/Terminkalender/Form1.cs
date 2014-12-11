namespace Terminkalender
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    using Terminkalender.Classes;
    using Terminkalender.Forms;

    public partial class Form1 : Form
    {
        private readonly List<Person> _Persons = new List<Person>();

        private readonly List<Appointment> _Appointments = new List<Appointment>();

        private readonly List<Location> _Locations = new List<Location>(); 

        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            PrefilLists();
            InitializeOlvs();
        }

        private void InitializeOlvs()
        {
            InitializeOlvAppointments();
            InitializeOlvPersons();
            InitializeOlvLocations();
        }

        private void InitializeOlvPersons()
        {
            OlvcFirstname.AspectGetter = delegate(object rowObject)
            {
                Person person = rowObject as Person;
                if (person == null)
                    return string.Empty;

                return person.FirstName;
            };

            OlvcLastname.AspectGetter = delegate(object rowObject)
            {
                Person person = rowObject as Person;
                if (person == null)
                    return string.Empty;

                return person.LastName;
            };

            OlvcPersonStreet.AspectGetter = delegate(object rowObject)
            {
                Person person = rowObject as Person;
                if (person == null)
                    return string.Empty;

                return person.Street;
            };

            OlvcPersonNr.AspectGetter = delegate(object rowObject)
            {
                Person person = rowObject as Person;
                if (person == null)
                    return string.Empty;

                return person.Nr;
            };

            OlvcPersonPostcode.AspectGetter = delegate(object rowObject)
            {
                Person person = rowObject as Person;
                if (person == null)
                    return string.Empty;

                return person.PostCode;
            };

            OlvcPersonTown.AspectGetter = delegate(object rowObject)
            {
                Person person = rowObject as Person;
                if (person == null)
                    return string.Empty;

                return person.Town;
            }; 
            
            OlvPersons.SetObjects(_Persons);
        }

        private void InitializeOlvLocations()
        {
            OlvcName.AspectGetter = delegate(object rowObject)
                { 
                    Location loc = rowObject as Location;
                    if (loc == null)
                        return string.Empty;

                    return loc.Name;
                };

            OlvcStreet.AspectGetter = delegate(object rowObject)
            {
                Location loc = rowObject as Location;
                if (loc == null)
                    return string.Empty;

                return loc.Street;
            };

            OlvcNumber.AspectGetter = delegate(object rowObject)
            {
                Location loc = rowObject as Location;
                if (loc == null)
                    return string.Empty;

                return loc.Number;
            };

            OlvcPostCode.AspectGetter = delegate(object rowObject)
            {
                Location loc = rowObject as Location;
                if (loc == null)
                    return string.Empty;

                return loc.Postcode;
            };

            OlvcTown.AspectGetter = delegate(object rowObject)
            {
                Location loc = rowObject as Location;
                if (loc == null)
                    return string.Empty;

                return loc.Town;
            };

            OlvLocations.SetObjects(_Locations);
        }

        private void InitializeOlvAppointments()
        {
            OlvcAppointmentDescription.AspectGetter = delegate(object rowObject)
            {
                Appointment app = rowObject as Appointment;
                if (app == null)
                    return string.Empty;

                return app.Description;
            }; 
            
            OlvcPerson.AspectGetter = delegate(object rowObject)
                {
                    Appointment app = rowObject as Appointment;
                    if (app == null)
                        return string.Empty;

                    return app.PersonOfAppointment.FirstName + " " + app.PersonOfAppointment.LastName;
                };

            OlvcLocation.AspectGetter = delegate(object rowObject)
                {
                    Appointment app = rowObject as Appointment;
                    if (app == null)
                        return string.Empty;

                    return app.LocationOfAppointment.Name;
                };

            OlvcDate.AspectGetter = delegate(object rowObject)
                {
                    Appointment app = rowObject as Appointment;
                    if (app == null)
                        return string.Empty;

                    return app.TimeOfAppointment.ToShortDateString();
                };

            OlvAppointments.SetObjects(_Appointments);
        }

        private void PrefilLists()
        {
            Person mario = new Person("Mario", "Sandhövel", "Taunusstraße", "72", "45968", "Gladbeck");
            Person sascha = new Person("Sascha", "Berghaus", "Auf dem Bauloh", "16", "58119", "Hagen");

            _Persons.Add(mario); 
            _Persons.Add(sascha);

            Location amana = new Location("Amana", "Veronikastraße", "36", "45131", "Essen");
            _Locations.Add(amana);

            Appointment arbeit = new Appointment(sascha, amana, new DateTime(2014, 11, 4), "Arbeit Arbeit");
            _Appointments.Add(arbeit);
        }

        private void BtnSortAppointments_Click(object sender, EventArgs e)
        {
            BtnSortAppointments.ContextMenuStrip.Show(BtnSortAppointments, 0, 23);
        }

        private void BtnAddAppointment_Click(object sender, EventArgs e)
        {
            NewAppointmentForm frm = new NewAppointmentForm(_Persons, _Locations);
            frm.ShowDialog();

            if (frm.NewAppointment == null)
                return;

            _Appointments.Add(frm.NewAppointment);
            OlvAppointments.AddObject(frm.NewAppointment);
        }

        private void BtnDeleteAppointment_Click(object sender, EventArgs e)
        {
            if (OlvAppointments.SelectedObject == null)
                return;

            Appointment appointmentToDelete = OlvAppointments.SelectedObject as Appointment;
            if (appointmentToDelete == null)
                return;

            _Appointments.Remove(appointmentToDelete);
            OlvAppointments.RemoveObject(appointmentToDelete);
        }

        private void TbFilterPerson_TextChanged(object sender, EventArgs e)
        {
            OlvPersons.ClearObjects();
            OlvPersons.SetObjects(TbFilterPerson.Text == string.Empty ? _Persons : _Persons.Where(pers => pers.LastName.Contains(TbFilterPerson.Text)));
        }

        private void BtnSortPersons_Click(object sender, EventArgs e)
        {
            BtnSortPersons.ContextMenuStrip.Show(BtnSortPersons, 0, 23);
        }

        private void BtnNewPerson_Click(object sender, EventArgs e)
        {
            NewPersonForm frm = new NewPersonForm();
            frm.ShowDialog();

            if (frm.Newperson == null)
                return;

            _Persons.Add(frm.Newperson);
            OlvPersons.AddObject(frm.Newperson);
        }

        private void BtnDeletePerson_Click(object sender, EventArgs e)
        {
            if (OlvPersons.SelectedObject == null)
                return;

            Person personToDelete = OlvPersons.SelectedObject as Person;

            if (personToDelete == null)
                return;

            _Persons.Remove(personToDelete);
            OlvPersons.RemoveObject(personToDelete);

            if (_Appointments.Any(app => app.PersonOfAppointment.Equals(personToDelete)))
            {
                List<Appointment> appointmentsToDelete = _Appointments.Where(app => app.PersonOfAppointment.Equals(personToDelete)).ToList();

                if (!appointmentsToDelete.Any())
                    return;

                _Appointments.RemoveAll(app => app.PersonOfAppointment.Equals(personToDelete));
                OlvAppointments.RemoveObjects(appointmentsToDelete);
            }
        }

        private void BtnSortLocations_Click(object sender, EventArgs e)
        {
            OlvLocations.ClearObjects();
            _Locations.Sort();
            OlvLocations.SetObjects(_Locations);
        }

        private void BtnNewLocation_Click(object sender, EventArgs e)
        {
            NewLocationForm frm = new NewLocationForm();
            frm.ShowDialog();

            if (frm.NewLocation == null)
                return;

            _Locations.Add(frm.NewLocation);
            OlvLocations.AddObject(frm.NewLocation);
        }

        private void BtnDeleteLocation_Click(object sender, EventArgs e)
        {
            if (OlvLocations.SelectedObject == null)
                return;
            Location locationToDelete = OlvLocations.SelectedObject as Location;

            if (locationToDelete == null)
                return;
            _Locations.Remove(locationToDelete);
            OlvLocations.RemoveObject(locationToDelete);

            if (_Appointments.Any(app => app.LocationOfAppointment.Equals(locationToDelete)))
            {
                List<Appointment> appointmentsToDelete = _Appointments.Where(app => app.LocationOfAppointment.Equals(locationToDelete)).ToList();

                if (!appointmentsToDelete.Any())
                    return;

                _Appointments.RemoveAll(app => app.LocationOfAppointment.Equals(locationToDelete));
                OlvAppointments.RemoveObjects(appointmentsToDelete);
            }
        }

        private void SortAppointments(IComparer<Appointment> comparer)
        {
            OlvAppointments.ClearObjects();
            _Appointments.Sort(comparer);
            OlvAppointments.SetObjects(_Appointments);
        }

        private void TsmiSortByPerson_Click(object sender, EventArgs e)
        {
            SortAppointments(new AppointmentByPersonComparer());
        }

        private void TsmiSortByDate_Click(object sender, EventArgs e)
        {
            SortAppointments(new AppointmentByDateComparer());
        }

        private void TsmiSortByLocation_Click(object sender, EventArgs e)
        {
            SortAppointments(new AppointmentByLocationComparer());
        }

        private void TsmiSortByDescription_Click(object sender, EventArgs e)
        {
            SortAppointments(new AppointmentByDescriptionComparer());
        }

        private void BtnEditAppointment_Click(object sender, EventArgs e)
        {
            if (OlvAppointments.SelectedObject == null)
                return;

            Appointment currentAppointment = OlvAppointments.SelectedObject as Appointment;

            if (currentAppointment == null)
                return;

            NewAppointmentForm frm = new NewAppointmentForm(_Persons, _Locations, currentAppointment);
            frm.ShowDialog();

            if (frm.NewAppointment == null)
                return;

            currentAppointment.Clone(frm.NewAppointment);
            OlvAppointments.RefreshObject(currentAppointment);
        }

        private void BtnEditLocation_Click(object sender, EventArgs e)
        {
            if (OlvLocations.SelectedObject == null)
                return;

            Location currentLocation = OlvLocations.SelectedObject as Location;

            if (currentLocation == null)
                return;

            NewLocationForm frm = new NewLocationForm(currentLocation);
            frm.ShowDialog();

            if (frm.NewLocation == null)
                return;

            currentLocation.Clone(frm.NewLocation);
            OlvLocations.RefreshObject(currentLocation);
        }

        private void BtnEditPerson_Click(object sender, EventArgs e)
        {
            if (OlvPersons.SelectedObject == null)
                return;

            Person currentPerson = OlvPersons.SelectedObject as Person;

            if (currentPerson == null)
                return;

            NewPersonForm frm = new NewPersonForm(currentPerson);
            frm.ShowDialog();

            if (frm.Newperson == null)
                return;

            currentPerson.Clone(frm.Newperson);
            OlvPersons.RefreshObject(currentPerson);
        }

        private void TsmiSortByName_Click(object sender, EventArgs e)
        {
            SortPersons(new PersonByLastNameComparer());
        }

        private void SortPersons(IComparer<Person> comparer)
        {
            OlvPersons.ClearObjects();
            _Persons.Sort(comparer);
            OlvPersons.SetObjects(_Persons);
        }
        
        private void TsmiSortByPostcode_Click(object sender, EventArgs e)
        {
            SortPersons(new PersonByPostCodeComparer());
        }

        private void TsmiSortByTown_Click(object sender, EventArgs e)
        {
            SortPersons(new PersonByTownComparer());
        }
    }
}
