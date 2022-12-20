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
    public partial class UserFeederChoiseView : Form, IUserFeederChoiseView
    {
        public UserFeederChoiseView()
        {
            InitializeComponent();
        }

        public event Action ChoiseFeeder;

        private void Feeder_1_Button_Click(object sender, EventArgs e)
        {
            //AddInitiative?.Invoke();
        }

        private void Feeder_2_Button_Click(object sender, EventArgs e)
        {

        }

        private void Feeder_3_Button_Click(object sender, EventArgs e)
        {

        }

        private void Feeder_4_Button_Click(object sender, EventArgs e)
        {

        }

        private void Feeder_5_Button_Click(object sender, EventArgs e)
        {

        }

        private void MenuFeeders_ChoiserUser_ScrollBar_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void FeederChoiseUserView_Load(object sender, EventArgs e)
        {

        }

        public new void Show()
        {
            base.Show();
        }
    }
}
