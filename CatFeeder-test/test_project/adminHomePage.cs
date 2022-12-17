using Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test_project
{
    public partial class AdminHomePage : Form, IHomeAdmin
    {
        public event Action evShowLogOut;
        public event Action evShowFeederIDiist;

        private readonly ApplicationContext context;
        public AdminHomePage(ApplicationContext context)
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

		private void label4_Click(object sender, EventArgs e)
		{

		}
	}
}
