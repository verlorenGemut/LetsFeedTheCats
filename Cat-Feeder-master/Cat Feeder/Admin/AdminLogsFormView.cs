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
    public partial class AdminLogsFormView : Form, IAdminLogsFormView
    {
        public string textLog;

        public event Action ChooseUser;
        public event Action ChooseLog;
        public event Action PrintAllLogs;
        public event Action ExportLogs;

        public AdminLogsFormView()
        {
            InitializeComponent();
        }

        private void ShowAllLogsButton_Click(object sender, EventArgs e)
        {
            PrintAllLogs?.Invoke();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ExportLogs?.Invoke();
        }

        private void ShowLogButton_Click(object sender, EventArgs e)
        {
            
          
        }

        private void AdminLogsFormView_Load(object sender, EventArgs e)
        {

        }

        private void logButton9_Click(object sender, EventArgs e)
        {
            ChooseLog?.Invoke();
        }

        private void userUpDown_SelectedItemChanged(object sender, EventArgs e)
        {
            ChooseUser?.Invoke();
        }

        private void logButton1_Click(object sender, EventArgs e)
        {
            ChooseLog?.Invoke();
        }

        private void logButton2_Click(object sender, EventArgs e)
        {
            ChooseLog?.Invoke();
        }

        private void logButton3_Click(object sender, EventArgs e)
        {
            ChooseLog?.Invoke();
        }

        private void logButton4_Click(object sender, EventArgs e)
        {
            ChooseLog?.Invoke();
        }

        private void logButton5_Click(object sender, EventArgs e)
        {
            ChooseLog?.Invoke();
        }

        private void logButton6_Click(object sender, EventArgs e)
        {
            ChooseLog?.Invoke();
        }

        private void logButton7_Click(object sender, EventArgs e)
        {
            ChooseLog?.Invoke();
        }

        private void logButton8_Click(object sender, EventArgs e)
        {
            ChooseLog?.Invoke();
        }

        private void logButton10_Click(object sender, EventArgs e)
        {
            ChooseLog?.Invoke();
        }

        public new void Show()
        {
            base.Show();
        }
    }
}
