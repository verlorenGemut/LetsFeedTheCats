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
    public partial class EditFeeder : Form
    {
        public EditFeeder()
        {
            InitializeComponent();

            //TODO set filds according to database
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //TODO save info to database

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

        private void btnImportSchedule_Click(object sender, EventArgs e)
        {
            //TODO get type of the feeder and open shedule editor
        }
    }
}
