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
    public partial class Feeder_ID_list : Form, IFeederIDlist
    {
        public Feeder_ID_list()
        {
            InitializeComponent();
        }

        public event Action evShowGoback;
        public event Action<string> evAddFeeder;
        public event Action<string> evRemoveFeeder;

        private void feeder_id_list_Load(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            evShowGoback?.Invoke();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            evAddFeeder?.Invoke(feeder_id_txtbx.Text);
        }

        public void display_GLOBAL_feeder_list(List<Feeder> GLOBAL_feederlist)
        {

            Controls["feederIDs"].Controls.Clear();

            if (GLOBAL_feederlist == null) return;
            int size = GLOBAL_feederlist.Count;

            int i;

            List<Button> removeButtons = new List<Button>();
            List<Label> feederNames = new List<Label>();
            List<Label> feederIDs = new List<Label>();
            List<Label> feederOwners = new List<Label>();

            for (i = 0; i < size; i++)
            {
                removeButtons.Add(new Button());
                removeButtons[i].Tag = GLOBAL_feederlist[i].strFeederID;
                removeButtons[i].Click += (sender, e) =>
                {
                    Button _sender = (Button)sender;
                    evRemoveFeeder?.Invoke((string)_sender.Tag);
                };
                removeButtons[i].Location = new Point(380, 35 * i);
                removeButtons[i].Width = 100;
                removeButtons[i].Visible = true;
                removeButtons[i].Text = "Delete";
                Controls["feederIDs"].Controls.Add(removeButtons[i]);


                feederNames.Add(new Label());
                feederNames[i].Location = new Point(0, 35 * i);
                feederNames[i].Width = 100;
                feederNames[i].Visible = true;
                feederNames[i].Text = GLOBAL_feederlist[i].strName;
                Controls["feederIDs"].Controls.Add(feederNames[i]);

                feederIDs.Add(new Label());
                feederIDs[i].Location = new Point(110, 35 * i);
                feederIDs[i].Width = 100;
                feederIDs[i].Visible = true;
                feederIDs[i].Text = GLOBAL_feederlist[i].strFeederID;
                Controls["feederIDs"].Controls.Add(feederIDs[i]);

                feederOwners.Add(new Label());
                feederOwners[i].Location = new Point(220, 35 * i);
                feederOwners[i].Width = 100;
                feederOwners[i].Visible = true;
                feederOwners[i].Text = GLOBAL_feederlist[i].strUserID;
                Controls["feederIDs"].Controls.Add(feederOwners[i]);
            }
        }
    }
}
