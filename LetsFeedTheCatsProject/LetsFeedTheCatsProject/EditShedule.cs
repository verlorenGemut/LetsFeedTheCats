using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsFeedTheCatsProject
{
    public partial class EditShedule : Form
    {
        public EditShedule()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            EditFeeder dlgEditFeeder = (EditFeeder)Application.OpenForms["EditFeeder"];
            if (dlgEditFeeder == null)
            {
                dlgEditFeeder = new EditFeeder();
                dlgEditFeeder.Show();
            }
            else
            {
                dlgEditFeeder.Show();
                dlgEditFeeder.Activate();
            }

            this.Hide();
        }

        private void tbHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void tbAddFeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //TODO save data to database

            EditFeeder dlgEditFeeder = (EditFeeder)Application.OpenForms["EditFeeder"];
            if (dlgEditFeeder == null)
            {
                dlgEditFeeder = new EditFeeder();
                dlgEditFeeder.Show();
            }
            else
            {
                dlgEditFeeder.Show();
                dlgEditFeeder.Activate();
            }

            this.Hide();
        }
    }
}
