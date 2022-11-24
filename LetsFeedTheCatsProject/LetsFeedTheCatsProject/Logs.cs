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
    public partial class Logs : Form
    {
        public Logs()
        {
            InitializeComponent();

            //TODO need to check active is Admin or User => change Logs label
            /*Name = "Total Logs";
            lblLogs.Text = "Total Logs";*/

            //TODO: need to initializate the table
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //TODO need to check active is Admin or User => go back to someone's welcome screen

            WelcomeAdmin dlgWelcomeAdmin = (WelcomeAdmin)Application.OpenForms["WelcomeAdmin"];
            if (dlgWelcomeAdmin == null)
            {
                dlgWelcomeAdmin = new WelcomeAdmin();
                dlgWelcomeAdmin.Show();
            }
            else
            {
                dlgWelcomeAdmin.Show();
                dlgWelcomeAdmin.Activate();
            }

            this.Hide();
        }

        private void Logs_FormClosed(object sender, FormClosedEventArgs e)
        {
            //need to vertificaton from user "Are you sure you want to exit,?"
            //IN ALL FORMS

            for (int i = 1; i < Application.OpenForms.Count; ++i)
                Application.OpenForms[i].Close();
        }
    }
}
