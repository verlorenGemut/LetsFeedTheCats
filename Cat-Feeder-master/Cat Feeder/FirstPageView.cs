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
using DAL;

namespace Cat_Feeder
{
    public partial class FirstPageView : Form, IFirstPageView
    {
        string status = "User";
        

        public string password => PasswordBox.Text;
        public string login => loginBox.Text;

        public event Action Connection;
        public FirstPageView()
        {
            InitializeComponent();
            DBHelper.EstablishConnection();

        }
        public event Action ShowUserMainPageView;
        public event Action ShowAdminPageView;
        
        public new void Show()
        {
            base.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (PasswordBox.Text.Length == 0 && loginBox.Text.Length ==0)
            {
                MessageBox.Show($"Вы не ввели данные");
            } else if(password.Length < 3 || password.Length >8 || login.Length < 2 || login.Length > 15)
            {
                MessageBox.Show($"Проверьте корректность введеных данных\nLogin(от 2 до 15 символов)\nPassword(2-8 символов)\nUser/Admin");
            } else {
                if (status.Equals("User"))
                {
                    ShowUserMainPageView?.Invoke();
                }
                else {
                    ShowAdminPageView?.Invoke();
                }
                
            }
            
        }
        //login
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //password
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void loginBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            PasswordBox.MaxLength = 8;
            PasswordBox.PasswordChar = '*';
            if (PasswordBox.Text.Length > 8)
            {
                MessageBox.Show("Длинна пароля должна быть не больше 8 символов");
            }
        }
        private void UserRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // приводим отправителя к элементу типа RadioButton
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                //устанавливаем статус Пользователь
                status = "User";
            }
        }
        private void AdminRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // приводим отправителя к элементу типа RadioButton
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                //устанавливаем статус Админ
                status = "Admin";
            }
        }
    }
}
