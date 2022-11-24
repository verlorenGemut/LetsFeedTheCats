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
    public partial class WelcomeAdmin : Form
    {
        public WelcomeAdmin()
        {
            InitializeComponent();

            //TODO get Admin Name from database
            //lblHelloAdmin.Text = "Hello, ADMINNAME"

            //TODO load list of users in combobox 
            //TODO all work with combobox + make fields visuble
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            WelcomeScreen dlgWelcomeScreen = (WelcomeScreen)Application.OpenForms["WelcomeScreen"];
            if (dlgWelcomeScreen == null)
            {
                dlgWelcomeScreen = new WelcomeScreen();
                dlgWelcomeScreen.Show();
            }
            else
            {
                dlgWelcomeScreen.Show();
                dlgWelcomeScreen.Activate();
            }

            this.Hide();
        }

        private void btnExportLogs_Click(object sender, EventArgs e)
        {
            Logs dlgLogs = (Logs)Application.OpenForms["Logs"];
            if (dlgLogs == null)
            {
                dlgLogs = new Logs();
                dlgLogs.Show();
            }
            else
            {
                dlgLogs.Show();
                dlgLogs.Activate();
            }

            this.Hide();
        }

        private void WelcomeAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            //need to vertificaton from user "Are you sure you want to exit,?"
            //IN ALL FORMS

            for (int i = 1; i < Application.OpenForms.Count; ++i)
                Application.OpenForms[i].Close();
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            Notifications dlgNotifiactions = (Notifications)Application.OpenForms["Notifications"];
            if (dlgNotifiactions == null)
            {
                dlgNotifiactions = new Notifications();
                dlgNotifiactions.Show();
            }
            else
            {
                dlgNotifiactions.Show();
                dlgNotifiactions.Activate();
            }

            this.Hide();
        }

        private void btnStatusBar_Click(object sender, EventArgs e)
        {
            StatusBar dlgStatusBar = (StatusBar)Application.OpenForms["StatusBar"];
            if (dlgStatusBar == null)
            {
                dlgStatusBar = new StatusBar();
                dlgStatusBar.Show();
            }
            else
            {
                dlgStatusBar.Show();
                dlgStatusBar.Activate();
            }

            this.Hide();
        }
    }
}
