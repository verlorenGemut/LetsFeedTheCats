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

        public event Action ChooseTimetable;
        public event Action ExportTimetable;
        public event Action ImportTimetable;
        public event Action SaveTimetable;
        public event Action ChooseFeed;
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
            // НЕ ЗНАЮ ЗАЧЕМ И ДЛЯ ЧЕГО                                             ЧЕРНЕЦКИЙ   ВЛАДИМИР
        }

        private void ExportTimetableButton_Click(object sender, EventArgs e)
        {
            ExportTimetable?.Invoke();
        }

        private void ImportTimetableButton_Click(object sender, EventArgs e)
        {
            ImportTimetable?.Invoke();
        }

        private void ChooseFeedButton_Click(object sender, EventArgs e)
        {
            ChooseFeed?.Invoke();
        }

        private void Timetable_Button1_Click(object sender, EventArgs e)
        {
            ChooseTimetable?.Invoke();
        }

        private void SaveTametableButton_Click(object sender, EventArgs e)
        {
            SaveTimetable?.Invoke();
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
