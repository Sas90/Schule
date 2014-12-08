namespace Terminkalender.Forms
{
    using System;
    using System.Windows.Forms;

    using Terminkalender.Classes;

    public partial class NewPersonForm : Form
    {
        public NewPersonForm()
        {
            InitializeComponent();
            TbFirstname.Text = "Hannelore";
            TbLastname.Text = "Meier";
            TbStreet.Text = "Kanalbrücke";
            TbNr.Text = "1";
            TbPostCode.Text = "12345";
            TbTown.Text = "Marxloh";
        }

        public Person Newperson { get; set; }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TbFirstname.Text == string.Empty)
            {
                MessageBox.Show(@"Bitte Vornamen eingeben");
                return;
            }

            if (TbLastname.Text == string.Empty)
            {
                MessageBox.Show(@"Bitte Nachnamen eingeben");
                return;
            }

            if (TbStreet.Text == string.Empty)
            {
                MessageBox.Show(@"Bitte Straße eingeben");
                return;
            }

            if (TbNr.Text == string.Empty)
            {
                MessageBox.Show(@"Bitte Hausnummer eingeben");
                return;
            }

            if (TbPostCode.Text == string.Empty)
            {
                MessageBox.Show(@"Bitte PLZ eingeben");
                return;
            }

            if (TbTown.Text == string.Empty)
            {
                MessageBox.Show(@"Bitte Stadt eingeben");
                return;
            }

            Newperson = new Person(TbFirstname.Text, TbLastname.Text, TbStreet.Text, TbNr.Text, TbPostCode.Text, TbTown.Text);

            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Newperson = null;
            Close();
        }
    }
}
