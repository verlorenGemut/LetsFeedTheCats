using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsFeedTheCatsProject
{
    public partial class ErrorWindow : Form
    {
        public ErrorWindow()
        {
            InitializeComponent();
        }
        public ErrorWindow(string name, string label, string message, string button)
        {
            InitializeComponent();
            this.Text = name;
            this.lblError.Text = label;
            this.lblErrorMessage.Text = message;
            this.btnTryAgain.Text = button;
        }

        private void btnTryAgain_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
