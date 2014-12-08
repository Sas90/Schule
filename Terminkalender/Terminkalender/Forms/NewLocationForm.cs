namespace Terminkalender.Forms
{
    using System;
    using System.Windows.Forms;

    using Terminkalender.Classes;

    public partial class NewLocationForm : Form
    {
        public NewLocationForm()
        {
            InitializeComponent();

            TbName.Text = @"HNBK";
            TbNumber.Text = @"50";
            TbPostcode.Text = @"45144";
            TbStreet.Text = @"Dahnstraße";
            TbTown.Text = @"Essen";
        }

        public Location NewLocation { get; set; }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TbName.Text == string.Empty)
            {
                MessageBox.Show(@"Bitte geben Sie einen Namen ein.");
                return;
            }

            if (TbNumber.Text == string.Empty)
            {
                MessageBox.Show(@"Bitte geben Sie eine Hausnummer ein.");
                return;
            }

            if (TbPostcode.Text == string.Empty)
            {
                MessageBox.Show(@"Bitte geben Sie eine Postleitzahl ein.");
                return;
            }

            if (TbStreet.Text == string.Empty)
            {
                MessageBox.Show(@"Bitte geben Sie eine Straße ein.");
                return;
            }

            if (TbTown.Text == string.Empty)
            {
                MessageBox.Show(@"Bitte geben Sie eine Stadt ein.");
                return;
            }

            NewLocation = new Location(TbName.Text, TbStreet.Text, TbNumber.Text, TbPostcode.Text, TbTown.Text);
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            NewLocation = null;
            Close();
        }
    }
}
