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
    public partial class UserMainPageView : Form, IUserMainPageView
    {
        public UserMainPageView()
        {

            InitializeComponent();
            
        }

        
        public new void Show()
        {
            base.Show();
        }

        public event Action evShowMakeMarkFormView;
        public event Action evShowLogsFormView;
        public event Action evShowTimetableView;
        public event Action evShowFeedVeiw;



        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

  

        private void UserMainPage_Load(object sender, EventArgs e)
        {

        }

        
        private void createNoteButton_Click(object sender, EventArgs e)
        {
            evShowMakeMarkFormView?.Invoke();
        }

        private void note1_Click(object sender, EventArgs e)
        {

        }

        private void note2_Click(object sender, EventArgs e)
        {

        }

        private void logButton_Click(object sender, EventArgs e)
        {
            evShowLogsFormView?.Invoke();
        }

        private void timetableButton_Click(object sender, EventArgs e)
        {
            evShowTimetableView?.Invoke();
        }

        private void feeder2_Click(object sender, EventArgs e)
        {
            evShowFeedVeiw?.Invoke();
        }

        private void feeder4_Click(object sender, EventArgs e)
        {
            evShowFeedVeiw?.Invoke();
        }

        private void feeder3_Click(object sender, EventArgs e)
        {
            evShowFeedVeiw?.Invoke();
        }

        private void feeder1_Click(object sender, EventArgs e)
        {
            evShowFeedVeiw?.Invoke();
        }
    }
}
