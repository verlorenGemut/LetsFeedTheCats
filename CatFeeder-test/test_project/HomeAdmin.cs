using Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CatFeeder
{
    public partial class HomeAdmin : Form, IHomeAdmin
    {
        public event Action evShowLogOut;
        public event Action evShowFeederIDiist;

        private readonly ApplicationContext context;
        public HomeAdmin(ApplicationContext context)
        {
            this.context = context;
            InitializeComponent();
        }

        private void home_admin_Load(object sender, EventArgs e)
        {

        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            evShowLogOut?.Invoke();
        }

        private void Manage_feeder_ids_btn_Click(object sender, EventArgs e)
        {
            evShowFeederIDiist?.Invoke();
        }

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
