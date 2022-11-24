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
    public partial class ErrorWindow : Form
    {
        public ErrorWindow()
        {
            InitializeComponent();
        }

        private void btnTryAgain_Click(object sender, EventArgs e)
        {
            SignIn dlgSignIn = new SignIn();
            dlgSignIn.ShowDialog();
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp dlgSignUp = (SignUp)Application.OpenForms["SignUp"];
            if (dlgSignUp == null)
            {
                dlgSignUp = new SignUp();
                dlgSignUp.Show();
            }
            else
            {
                dlgSignUp.Activate();
            }

            this.Hide();
        }
    }
}
