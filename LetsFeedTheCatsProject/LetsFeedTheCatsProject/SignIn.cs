using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LetsFeedTheCatsProject
{
    
    public partial class SignIn : Form
    {
        SignUpDB RegisterDB = new SignUpDB();
        public SignIn()
        {
            InitializeComponent();

            pbSecurity.Image = Image.FromFile("../../../res/pictures/eyeClose.png");
            pbSecurity.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pbSecurity_Click(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = !tbPassword.UseSystemPasswordChar;

            if(tbPassword.UseSystemPasswordChar)
            {
                pbSecurity.Image = Image.FromFile("../../../res/pictures/eyeClose.png");
            }
            else
            {
                pbSecurity.Image = Image.FromFile("../../../res/pictures/eyeOpen.png");
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

            var emailUser = tbEmail.Text;
            var passUser = tbPassword.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            string queryString = $"select id_user, user_email, password_user from signup where user_email = '{emailUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(queryString, RegisterDB.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                MessageBox.Show("Your account is waiting for vertification from Admin", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SignIn SignIpform = new SignIn();
                this.Hide();
                SignIpform.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Check your e-mail!", "E-mail user is busy", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
