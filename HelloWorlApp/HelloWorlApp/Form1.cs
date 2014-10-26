using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorlApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congrats", "Hellow World"); //first string is the headin,second is inside the box.
        }

        private void showButton2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            MessageBox.Show("Hi" + name +" how are you","CongratsApp" , MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
        }

        private void showButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Assalamualaikum");
        }
    }
}
