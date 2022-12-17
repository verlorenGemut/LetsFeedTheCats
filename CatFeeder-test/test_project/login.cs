using Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatFeeder
{
    public partial class Form1 : Form, ILogIn
    {
        private readonly ApplicationContext context;

        public event Action<string, string> evShowLogIn;
        public event Action evShowRegisterScreen;

        public Form1(ApplicationContext context)
        {
            this.context = context;
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            evShowLogIn?.Invoke(username_txtbx.Text, password_txtbx.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void password_txtbx_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void no_account_btn_Click(object sender, EventArgs e)
        {
            evShowRegisterScreen?.Invoke();
        }
    }
}
