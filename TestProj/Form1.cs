using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Bechir was here!";
        }
    }
}
