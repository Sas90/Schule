namespace Terminkalender.Forms
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using Terminkalender.Classes;

    public partial class NewAppointmentForm : Form
    {
        public NewAppointmentForm(List<Person> persons, List<Location> locations, Appointment appointment = null)
        {
            InitializeComponent();
            CbxLocation.DataSource = locations;
            CbxLocation.DisplayMember = "Name";
            CbxPerson.DataSource = persons;
            CbxPerson.DisplayMember = "CompleteName";

            if (appointment != null)
            {
                TbName.Text = appointment.Description;
                CbxLocation.SelectedItem = appointment.LocationOfAppointment;
                CbxPerson.SelectedItem = appointment.PersonOfAppointment;
                dateTimePicker1.Value = appointment.TimeOfAppointment;
            }
            else
            {
                TbName.Text = @"Neuer Termin";
            }
        }

        public Appointment NewAppointment { get; set; }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            NewAppointment = null;
            Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            NewAppointment = new Appointment(CbxPerson.SelectedItem as Person, CbxLocation.SelectedItem as Location, dateTimePicker1.Value, TbName.Text);
            Close();
        }
    }
}
