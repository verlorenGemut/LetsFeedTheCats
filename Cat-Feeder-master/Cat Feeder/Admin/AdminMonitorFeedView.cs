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

        public event Action evChooseSensorFeeder;
        public event Action evChooseDispenserFeeder;
        public event Action evChooseUser;
        public event Action evSaveFeeder;
        public event Action evRemoveFeeder;
        public event Action evChooseFeeder;

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
            evChooseFeeder?.Invoke();
        }

        private void userDomainUpDown_SelectedItemChanged(object sender, EventArgs e)
        {
            evChooseUser?.Invoke();
        }

        private void feedorButton1_Click(object sender, EventArgs e)
        {
            evChooseFeeder?.Invoke();
        }

        private void feedorButton4_Click(object sender, EventArgs e)
        {
            evChooseFeeder?.Invoke();
        }

        private void feedorButton5_Click(object sender, EventArgs e)
        {
            evChooseFeeder?.Invoke();
        }

        private void nameFeederTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (typeFeeder.Equals("dispenser"))
            {
                evChooseDispenserFeeder?.Invoke();

            }
            else
            {
                evChooseSensorFeeder?.Invoke();
            }
            evSaveFeeder?.Invoke();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            evRemoveFeeder?.Invoke();
        }

        public new void Show()
        {
            base.Show();
        }
    }
}
