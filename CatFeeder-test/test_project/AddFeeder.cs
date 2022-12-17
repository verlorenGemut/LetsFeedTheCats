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
    public partial class AddFeeder : Form, IAddFeeder
    {
        public event Action evShowGoback;
        public event Action<string> evAddFeeder;
        private readonly ApplicationContext context;
        public AddFeeder(ApplicationContext context)
        {
            InitializeComponent();
            this.context = context;
        }

        private void add_feeder_Load(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            evShowGoback?.Invoke();
        }

        private void add_feeder_btn_Click(object sender, EventArgs e)
        {
            evAddFeeder?.Invoke(add_feeder_txtbx.Text);
        }

        private void add_feeder_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        public void Activation_result_response(short activation_result)
        {
            if (activation_result == 1)
                MessageBox.Show("Feeder is active !");
            else if (activation_result == 0)
                MessageBox.Show("Wrong ID or Feeder has been already acrivated");
        }

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
