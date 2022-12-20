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
    public partial class AdminMonitorFeedView : Form, IAdminMonitorFeedView
    {
        string typeFeeder = "sensor";
        public string name => nameFeederTextBox.Text;

        public AdminMonitorFeedView()
        {
            InitializeComponent();
        }

        public event Action ChooseSensorFeeder;
        public event Action ChooseDispenserFeeder;
        public event Action ChooseUser;
        public event Action SaveFeedor;
        public event Action RemoveFeedor;
        public event Action ChooseFeeder;

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sensorFeederRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            typeFeeder = "sensor";
        }

        private void splitContainer10_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void dispenserFeederRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            typeFeeder = "dispenser";
        }

        private void splitContainer12_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MonitorFeedAdminView_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChooseFeeder?.Invoke();
        }

        private void userDomainUpDown_SelectedItemChanged(object sender, EventArgs e)
        {
            ChooseUser?.Invoke();
        }

        private void feedorButton1_Click(object sender, EventArgs e)
        {
            ChooseFeeder?.Invoke();
        }

        private void feedorButton4_Click(object sender, EventArgs e)
        {
            ChooseFeeder?.Invoke();
        }

        private void feedorButton5_Click(object sender, EventArgs e)
        {
            ChooseFeeder?.Invoke();
        }

        private void nameFeederTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (typeFeeder.Equals("dispenser"))
            {
                ChooseDispenserFeeder?.Invoke();

            }
            else
            {
                ChooseSensorFeeder?.Invoke();
            }
            SaveFeedor?.Invoke();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            RemoveFeedor?.Invoke();
        }

        public new void Show()
        {
            base.Show();
        }
    }
}
