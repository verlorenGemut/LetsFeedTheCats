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
        public string strTextLog;

        public event Action evChooseUser;
        public event Action evChooseLog;
        public event Action evPrintAllLogs;
        public event Action evExportLogs;

        public AdminLogsFormView()
        {
            InitializeComponent();
        }

        private void ShowAllLogsButton_Click(object sender, EventArgs e)
        {
            evPrintAllLogs?.Invoke();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            evExportLogs?.Invoke();
        }

        private void ShowLogButton_Click(object sender, EventArgs e)
        {
            
          
        }

        private void AdminLogsFormView_Load(object sender, EventArgs e)
        {

        }

        private void logButton9_Click(object sender, EventArgs e)
        {
            evChooseLog?.Invoke();
        }

        private void userUpDown_SelectedItemChanged(object sender, EventArgs e)
        {
            evChooseUser?.Invoke();
        }

        private void logButton1_Click(object sender, EventArgs e)
        {
            evChooseLog?.Invoke();
        }

        private void logButton2_Click(object sender, EventArgs e)
        {
            evChooseLog?.Invoke();
        }

        private void logButton3_Click(object sender, EventArgs e)
        {
            evChooseLog?.Invoke();
        }

        private void logButton4_Click(object sender, EventArgs e)
        {
            evChooseLog?.Invoke();
        }

        private void logButton5_Click(object sender, EventArgs e)
        {
            evChooseLog?.Invoke();
        }

        private void logButton6_Click(object sender, EventArgs e)
        {
            evChooseLog?.Invoke();
        }

        private void logButton7_Click(object sender, EventArgs e)
        {
            evChooseLog?.Invoke();
        }

        private void logButton8_Click(object sender, EventArgs e)
        {
            evChooseLog?.Invoke();
        }

        private void logButton10_Click(object sender, EventArgs e)
        {
            evChooseLog?.Invoke();
        }

        public new void Show()
        {
            base.Show();
        }
    }
}
