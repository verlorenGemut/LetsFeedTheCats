using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation;


namespace Cat_Feeder
{
    public partial class AdminRegFormView : Form, IAdminRegFormView
    {
        public string password => PasswordBox.Text;
        public string login => loginBox.Text;

        public event Action<string, string> AddUser;
        public AdminRegFormView()
        {
            InitializeComponent();
        }

        private void loginBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            PasswordBox.MaxLength = 8;
        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (PasswordBox.Text.Length == 0 && loginBox.Text.Length == 0)
            {
                MessageBox.Show("Введите логин и пароль");
            } else if(login.Length == 0 || login.Length > 15 || login.Length < 2)
            {
                MessageBox.Show("Длинна догина должна быть от 2 до 15 символов");
            } else if (PasswordBox.Text.Length < 8)
            {
                MessageBox.Show("Длинна пароля должна быть 8 символов");
            } else
            {
                MessageBox.Show($"Пользователь зарегестрирован\nlogin: {login}\npassword: {password}");
                AddUser?.Invoke(login, password);
            }
        }

        public new void Show()
        {
            base.Show();
        }
    }
}
