using Model.Entity;
using Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace CatFeeder
{
    public partial class HomeUser : Form, IHomeUser
    {

        Button txtBox;
        public event Action evShowAddFeeder;
        public event Action evShowManageTimetables;
        public event Action evShowLogOut;
        public event Action<string> evShowFeederSettings;
        public event Action<string> evShowFeederInfo;

        private readonly ApplicationContext context;
        public HomeUser(ApplicationContext context)
        {
            this.context = context;
            InitializeComponent();
        }

        private void home_user_Load(object sender, EventArgs e)
        {
            
        }

        private void add_feeder_btn_Click(object sender, EventArgs e)
        {
            evShowAddFeeder?.Invoke();
        }

        private void manage_timetables_btn_Click(object sender, EventArgs e)
        {
            evShowManageTimetables?.Invoke();
        }

        private void quit_btn_Click(object sender, EventArgs e)
        {
            evShowLogOut?.Invoke();
        }

        public void display_feeder_list(List<Feeder> feederList)
        {
            if (feederList == null)
                return;

            int size = feederList.Count;
            int i;
            List<Button> infoButtons = new List<Button>();
            List<Button> settingsButtons = new List<Button>();
            List<Label> feederNames = new List<Label>();
            for (i = 0; i < size; i++)
            {
                infoButtons.Add(new Button());
                infoButtons[i].Tag = "FeederID: " + feederList[i].strFeederID + "\nTime: it's time to feed cat";
                infoButtons[i].Click += (sender, e) =>
                {
                    Button _sender = (Button)sender;
                    MessageBox.Show((string)_sender.Tag);
                };
                infoButtons[i].Location = new Point(200, 50*i);
                infoButtons[i].Width = 140;
                infoButtons[i].Visible = true;
                infoButtons[i].Text = "Info";
                Controls["feeders"].Controls.Add(infoButtons[i]);

                settingsButtons.Add(new Button());
                settingsButtons[i].Tag = feederList[i].strFeederID;
                settingsButtons[i].Click += (sender, e) =>
                {
                    Button _sender = (Button)sender;
                    
                    evShowFeederSettings?.Invoke((string)_sender.Tag);
                };
                settingsButtons[i].Location = new Point( 400, 50 * i);
                settingsButtons[i].Width = 140;
                settingsButtons[i].Visible = true;
                settingsButtons[i].Text = "Settings";
                Controls["feeders"].Controls.Add(settingsButtons[i]);

                feederNames.Add(new Label());
                feederNames[i].Location = new Point(50, 50 * i);
                feederNames[i].Width = 140;
                feederNames[i].Visible = true;
                feederNames[i].Text = feederList[i].strName;
                Controls["feeders"].Controls.Add(feederNames[i]);
            }
        }

		private void feeders_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
