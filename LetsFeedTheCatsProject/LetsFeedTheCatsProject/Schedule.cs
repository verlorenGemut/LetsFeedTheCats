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
    public partial class Schedule : Form
    {
        public Schedule()
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditShedule dlgEditShedule = (EditShedule)Application.OpenForms["EditShedule"];
            if (dlgEditShedule == null)
            {
                dlgEditShedule = new EditShedule();
                dlgEditShedule.Show();
            }
            else
            {
                dlgEditShedule.Show();
                dlgEditShedule.Activate();
            }

            this.Hide();
        }

        private void Schedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            //TODO: need to vertificaton from user "Are you sure you want to exit,?"
            //IN ALL FORMS

            for (int i = 1; i < Application.OpenForms.Count; ++i)
                Application.OpenForms[i].Close();
        }
    }
}
