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
    public partial class UserTimetableView : Form, IUserTimetableView
    {
        public string TitleOfTimetables => TitleBoxOfTimetables.Text;
        public string TextOfTimeTables => TextBoxOfTimeTables.Text;

        public event Action evChooseTimetable;
        public event Action evExportTimetable;
        public event Action evImportTimetable;
        public event Action evSaveTimetable;
        public event Action evChooseFeed;
        public UserTimetableView()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            base.Show();
        }
        
        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Timetable_Load(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
        }

        private void ExportTimetableButton_Click(object sender, EventArgs e)
        {
            evExportTimetable?.Invoke();
        }

        private void ImportTimetableButton_Click(object sender, EventArgs e)
        {
            evImportTimetable?.Invoke();
        }

        private void ChooseFeedButton_Click(object sender, EventArgs e)
        {
            evChooseFeed?.Invoke();
        }

        private void Timetable_Button1_Click(object sender, EventArgs e)
        {
            evChooseTimetable?.Invoke();
        }

        private void SaveTametableButton_Click(object sender, EventArgs e)
        {
            evSaveTimetable?.Invoke();
        }

        private void textBoxOfTimeTables_TextChanged(object sender, EventArgs e)
        {
            //TextBoxOfTimeTables.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
