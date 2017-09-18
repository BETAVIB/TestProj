using System;
using System.Windows.Forms;

namespace TestProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOussama_Click(object sender, EventArgs e)
        {
            label1.Text = "Ouss was here!";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            label1.Text = "Bechir was here!";
        }
    }
}
