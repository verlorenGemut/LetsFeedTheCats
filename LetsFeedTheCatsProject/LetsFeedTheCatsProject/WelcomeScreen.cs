using System.Windows.Forms;

namespace LetsFeedTheCatsProject
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();

            pbWelcomeCat.Image = Image.FromFile("C:/MEIN/BSU/sem5/tp/LetsFeedTheCats/LetsFeedTheCats/LetsFeedTheCatsProject/LetsFeedTheCatsProject/res/pictures/welcomeCat.png");
            pbWelcomeCat.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignIn dlgSignIn = (SignIn)Application.OpenForms["SignIn"];
            if(dlgSignIn == null)
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp dlgSignUp = (SignUp)Application.OpenForms["SignUp"];
            if (dlgSignUp == null)
            {
                dlgSignUp = new SignUp();
                dlgSignUp.Show();
            }
            else
            {
                dlgSignUp.Show();
                dlgSignUp.Activate();
            }

            this.Hide();
        }
        private void WelcomeScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            //need to vertificaton from user "Are you sure you want to exit,?"
            //IN ALL FORMS

            for (int i = 1; i < Application.OpenForms.Count; ++i)
               Application.OpenForms[i].Close();
        }
    }
}