using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formFillUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] name = new string[30];
        string[] fathersName = new string[30];
        string[] mothersName = new string[30];
        string[] sex = new string[30];
        int[] idNumber = new int[30];
        int i = 0;

       
        private void buttonSave_Click(object sender, EventArgs e)
        {
           
            i = Convert.ToInt32(comboBox1.Text);
            idNumber[i] = Convert.ToInt32(comboBox1.Text);
            name[i]=textBoxName.Text;
            fathersName[i]=textBoxFathersName.Text;
            mothersName[i] = textBoxMotersName.Text;
            if(radioMale.Checked==true)
            {
                sex[i] = "Male";
            }
            else
            {
                sex[i] = "Female";
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int infid=0;
            infid = Convert.ToInt16(textinfroll.Text);
            MessageBox.Show("Name=" + name[infid] + "\nId No.=" + idNumber[infid] + "\nFather's Name=" + fathersName[infid] + "\nmothers Name=" + mothersName[infid] + "\nSex=" + sex[infid]);
        }
       
    }
}
