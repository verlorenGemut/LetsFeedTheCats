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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();

            pbPassword.Image = Image.FromFile("C:\\MEIN\\BSU\\sem5\\tp\\LetsFeedTheCats\\LetsFeedTheCats\\LetsFeedTheCatsProject\\LetsFeedTheCatsProject\\res\\pictures\\eyeClose.png");
            pbPassword.SizeMode = PictureBoxSizeMode.StretchImage;

            pbPasswordConfirm.Image = Image.FromFile("C:\\MEIN\\BSU\\sem5\\tp\\LetsFeedTheCats\\LetsFeedTheCats\\LetsFeedTheCatsProject\\LetsFeedTheCatsProject\\res\\pictures\\eyeClose.png");
            pbPasswordConfirm.SizeMode = PictureBoxSizeMode.StretchImage;

            pbCheck.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void linkSignIp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn dlgSignIn = (SignIn)Application.OpenForms["SignIn"];
            if (dlgSignIn == null)
            {
                dlgSignIn = new SignIn();
                dlgSignIn.Show();
            }
            else
            {
                dlgSignIn.Show();
                dlgSignIn.Activate();
            }

            this.Hide();
        }

        private void pbPassword_Click(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = !tbPassword.UseSystemPasswordChar;

            if (tbPassword.UseSystemPasswordChar)
            {
                pbPassword.Image = Image.FromFile("C:\\MEIN\\BSU\\sem5\\tp\\LetsFeedTheCats\\LetsFeedTheCats\\LetsFeedTheCatsProject\\LetsFeedTheCatsProject\\res\\pictures\\eyeClose.png");
            }
            else
            {
                pbPassword.Image = Image.FromFile("C:\\MEIN\\BSU\\sem5\\tp\\LetsFeedTheCats\\LetsFeedTheCats\\LetsFeedTheCatsProject\\LetsFeedTheCatsProject\\res\\pictures\\eyeOpen.png");
            }
        }

        private void pbPasswordConfirm_Click(object sender, EventArgs e)
        {
            tbPasswordConfirm.UseSystemPasswordChar = !tbPasswordConfirm.UseSystemPasswordChar;

            if (tbPasswordConfirm.UseSystemPasswordChar)
            {
                pbPasswordConfirm.Image = Image.FromFile("C:\\MEIN\\BSU\\sem5\\tp\\LetsFeedTheCats\\LetsFeedTheCats\\LetsFeedTheCatsProject\\LetsFeedTheCatsProject\\res\\pictures\\eyeClose.png");
            }
            else
            {
                pbPasswordConfirm.Image = Image.FromFile("C:\\MEIN\\BSU\\sem5\\tp\\LetsFeedTheCats\\LetsFeedTheCats\\LetsFeedTheCatsProject\\LetsFeedTheCatsProject\\res\\pictures\\eyeOpen.png");
            }
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = 0; i < Application.OpenForms.Count; ++i)
                if (Application.OpenForms[i] != this)
                    Application.OpenForms[i].Close();
        }

        private void tbPasswordConfirm_Changed(object sender, EventArgs e)
        {
            string password = tbPassword.Text;
            string passwordConfirm = tbPasswordConfirm.Text;

            if (passwordConfirm == password)
            {
                pbCheck.Image = Image.FromFile("C:\\MEIN\\BSU\\sem5\\tp\\LetsFeedTheCats\\LetsFeedTheCats\\LetsFeedTheCatsProject\\LetsFeedTheCatsProject\\res\\pictures\\checked.png");
            }
            else
            {
                pbCheck.Image = Image.FromFile("C:\\MEIN\\BSU\\sem5\\tp\\LetsFeedTheCats\\LetsFeedTheCats\\LetsFeedTheCatsProject\\LetsFeedTheCatsProject\\res\\pictures\\notChecked.png");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //add checking e-mail with database => if user with that e-mail already exists, need to show message immediately
            //when Submit, need to show Message: "your account is waiting for vertification from Admin"
        }
    }
}
