using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LetsFeedTheCatsProject
{
    public partial class ManualFeeding : Form
    {
        public ManualFeeding()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            WelcomeUser dlgWelcomeUser = (WelcomeUser)Application.OpenForms["WelcomeUser"];
            if (dlgWelcomeUser == null)
            {
                dlgWelcomeUser = new WelcomeUser();
                dlgWelcomeUser.Show();
            }
            else
            {
                dlgWelcomeUser.Show();
                dlgWelcomeUser.Activate();
            }

            this.Hide();
        }

        private void tbAddFeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //TODO: need to change amount of feed in spreadsheet

            MessageBox.Show("You successfully feeded your cat!");

            WelcomeUser dlgWelcomeUser = (WelcomeUser)Application.OpenForms["WelcomeUser"];
            if (dlgWelcomeUser == null)
            {
                dlgWelcomeUser = new WelcomeUser();
                dlgWelcomeUser.Show();
            }
            else
            {
                dlgWelcomeUser.Show();
                dlgWelcomeUser.Activate();
            }

            this.Hide();
        }

        private void ManualFeeding_FormClosed(object sender, FormClosedEventArgs e)
        {
            //TODO: need to vertificaton from user "Are you sure you want to exit,?"
            //IN ALL FORMS

            for (int i = 1; i < Application.OpenForms.Count; ++i)
                Application.OpenForms[i].Close();
        }
    }
}
