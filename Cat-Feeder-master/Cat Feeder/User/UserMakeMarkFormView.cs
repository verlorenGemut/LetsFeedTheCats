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
    public partial class UserMakeMarkFormView : Form, IUserMakeMarkFormView
    {
        public string Note => TextBoxOfTimeTables.Text;        //Альтернативно         ЧЕРНЕЦКИЙ   ВЛАДИМИР
        public UserMakeMarkFormView()
        {
            InitializeComponent();
        }

        public event Action ChoiseFeeder;
        public event Action MakeNoteToFeeder;
        public event Action MakeNoteByHand;

        public new void Show()
        {
            base.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //  НЕ ПОНЯТНО ДЛЯ ЧЕГО             ЧЕРНЕЦКИЙ   ВЛАДИМИР
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InfoKarmushkaField_Click(object sender, EventArgs e)
        {

        }

        private void MakeMarkForm_Load(object sender, EventArgs e)
        {

        }

        private void NoteByHandButton_Click(object sender, EventArgs e)
        {
            MakeNoteByHand?.Invoke();
        }

        private void ApplyNoteToFeederButton_Click(object sender, EventArgs e)
        {
            MakeNoteToFeeder?.Invoke();
        }

        private void Feeder1_Button_Click(object sender, EventArgs e)
        {
            ChoiseFeeder?.Invoke();
        }

        private void Feeder2_Button_Click(object sender, EventArgs e)
        {
            ChoiseFeeder?.Invoke();
        }

        private void Feeder3_Button_Click(object sender, EventArgs e)
        {
            ChoiseFeeder?.Invoke();
        }

        private void Feeder4_Button_Click(object sender, EventArgs e)
        {
            ChoiseFeeder?.Invoke();
        }

        private void Feeder5_Button_Click(object sender, EventArgs e)
        {
            ChoiseFeeder?.Invoke();
        }

        private void Feeder6_Button_Click(object sender, EventArgs e)
        {
            ChoiseFeeder?.Invoke();
        }

        private void Feeder7_Button_Click(object sender, EventArgs e)
        {
            ChoiseFeeder?.Invoke();
        }

        private void Feeder8_Button_Click(object sender, EventArgs e)
        {
            ChoiseFeeder?.Invoke();
        }

        private void Feeder9_Button_Click(object sender, EventArgs e)
        {
            ChoiseFeeder?.Invoke();
        }

        private void Feeder10_Button_Click(object sender, EventArgs e)
        {
            ChoiseFeeder?.Invoke();
        }

        private void Feeder11_Button_Click(object sender, EventArgs e)
        {
            ChoiseFeeder?.Invoke();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxOfTimeTables_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
