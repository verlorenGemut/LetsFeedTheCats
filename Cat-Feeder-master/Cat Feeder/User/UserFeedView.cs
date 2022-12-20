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
    public partial class UserFeedView : Form, IUserFeedView
    {
        public string timetableName => textBoxNameTimetable.Text;

        public string timetable => textBoxTimetable.Text;

        public UserFeedView()
        {
            InitializeComponent();
        }

        public event Action evSaveTimetable;
        public event Action evShowExistTimetable;

        public new void Show()
        {
            base.Show();
        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void splitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FeedView_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNameTimetable_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void saveTimetableButton_Click(object sender, EventArgs e)
        {
            evSaveTimetable?.Invoke();
        }

        private void chooseExistTimetableButton_Click(object sender, EventArgs e)
        {
            evShowExistTimetable?.Invoke();
        }

        private void textBoxTimetable_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
