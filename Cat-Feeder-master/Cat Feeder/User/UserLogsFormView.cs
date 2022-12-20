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
    public partial class UserLogsFormView : Form, IUserLogsFormView
    {
        public UserLogsFormView()
        {
            InitializeComponent();
        }

        public event Action evShowAllLogs;
        public event Action evExportLogs;
        public event Action<string> evChooseLog;

        public new void Show()
        {
            base.Show();
        }
        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserLogsFormView_Load(object sender, EventArgs e)
        {

        }

        private void ShowAllLogsButton_Click(object sender, EventArgs e)
        {
            evShowAllLogs?.Invoke();
        }

        private void ExportLogButton_Click(object sender, EventArgs e)
        {
            evExportLogs?.Invoke();
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            string textLog = LogButton.Text;
            evChooseLog?.Invoke(textLog);
        }
    }
}
