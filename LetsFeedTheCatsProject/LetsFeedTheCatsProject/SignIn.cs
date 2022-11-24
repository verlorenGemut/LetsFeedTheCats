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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();

            pbSecurity.Image = Image.FromFile("C:\\MEIN\\BSU\\sem5\\tp\\LetsFeedTheCats\\LetsFeedTheCats\\LetsFeedTheCatsProject\\LetsFeedTheCatsProject\\res\\pictures\\eyeClose.png");
            pbSecurity.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pbSecurity_Click(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = !tbPassword.UseSystemPasswordChar;

            if(tbPassword.UseSystemPasswordChar)
            {
                pbSecurity.Image = Image.FromFile("C:\\MEIN\\BSU\\sem5\\tp\\LetsFeedTheCats\\LetsFeedTheCats\\LetsFeedTheCatsProject\\LetsFeedTheCatsProject\\res\\pictures\\eyeClose.png");
            }
            else
            {
                pbSecurity.Image = Image.FromFile("C:\\MEIN\\BSU\\sem5\\tp\\LetsFeedTheCats\\LetsFeedTheCats\\LetsFeedTheCatsProject\\LetsFeedTheCatsProject\\res\\pictures\\eyeOpen.png");
            }
        }

        private void SignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = 0; i < Application.OpenForms.Count; ++i)
                if (Application.OpenForms[i] != this)
                    Application.OpenForms[i].Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //need to check e-mail and password with database
            //or show Error Window

            //if this User is an Admin => show another Hello Window


            //DELETE THIS
            //NEED TO TESTING
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
    }
}
