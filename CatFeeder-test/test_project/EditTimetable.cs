using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model.Entity;
using Presenter;

namespace CatFeeder
{
    public partial class EditTimetable : Form, IEditTimetable
    {
        private readonly ApplicationContext context;

        public event Action<string> evRemoveTimestamp;
        public event Action evShowGoback;
      
        public EditTimetable(ApplicationContext context)
        {
            this.context = context;
            InitializeComponent();
        }

        public void display_timestamp_list(Timetable timetable)
        {
            List <Time> timestamps = timetable.timeToFeed;

            if (timestamps == null) return;
            int size = timestamps.Count;

            int i;
            List<TextBox> timeTextBoxes = new List<TextBox>();
            List<Button> removeButtons = new List<Button>();

            for (i = 0; i < size; i++)
            {

                removeButtons.Add(new Button());
                removeButtons[i].Tag = timestamps[i].ID;
                removeButtons[i].Click += (sender, e) =>
                {
                    Button _sender = (Button)sender;
                    evRemoveTimestamp?.Invoke(Convert.ToString(_sender.Tag));
                };
                removeButtons[i].Location = new Point(180, 50 * i);
                removeButtons[i].Width = 80;
                removeButtons[i].Visible = true;
                removeButtons[i].Text = "Delete";
                Controls["timestamps"].Controls.Add(removeButtons[i]);
            }

        }

        private void edit_timetable_Load(object sender, EventArgs e)
        {

        }

		private void save_btn_Click(object sender, EventArgs e)
		{

		}

		private void add_btn_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
            evShowGoback?.Invoke();
        }

		private void button2_Click(object sender, EventArgs e)
		{

		}
        public void update_result_response(short result_code)
        {

        }
    }
}
