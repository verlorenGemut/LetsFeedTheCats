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
    public partial class WelcomeUser : Form
    {
        public WelcomeUser()
        {
            InitializeComponent();

            //TODO get User Name from database
            //lblHelloAdmin.Text = "Hello, USERNAME"

            //TODO load list of feeders in combobox 
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

        private void WelcomeUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            //TODO: need to vertificaton from user "Are you sure you want to exit,?"
            //IN ALL FORMS

            for (int i = 1; i < Application.OpenForms.Count; ++i)
                Application.OpenForms[i].Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
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
    }
}
