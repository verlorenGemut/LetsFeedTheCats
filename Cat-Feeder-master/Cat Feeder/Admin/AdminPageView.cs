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
    public partial class AdminPageView : Form, IAdminPageView
    {
        public AdminPageView()
        {
            InitializeComponent();
        }

        public event Action evShowAdminRegFormView;
        public event Action evShowAdminMonitorFeedView;
        public event Action evShowAdminLogsFormView;
        public event Action evShowAdminTimetableView;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void monitorFeederButton_Click(object sender, EventArgs e)
        {
            evShowAdminMonitorFeedView?.Invoke();
        }

        private void regButton_Click_1(object sender, EventArgs e)
        {
            evShowAdminRegFormView?.Invoke();
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            evShowAdminLogsFormView?.Invoke();
        }

        private void timtableButton_Click(object sender, EventArgs e)
        {
            evShowAdminTimetableView?.Invoke();
        }

        public new void Show()
        {
            base.Show();
        }
    }
}
