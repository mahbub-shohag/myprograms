using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSellingApp27sep_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string custumerName;
        private int ticketQuantity;
        private double totalAmount;
        private const int perTiccketPrice = 10;
        private void okButton_Click(object sender, EventArgs e)
        {
           custumerName = customrNameTextBox.Text;
           ticketQuantity = int.Parse(TicketQuantityTextBox.Text);
            totalAmount = perTiccketPrice*ticketQuantity;
        }

        private void showDetailButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mr."+custumerName +" please pay :"+totalAmount+"tk for "+ticketQuantity +" tickets") ;
          clear();

        }

        void clear()
        {
            customrNameTextBox.Text = "";
            TicketQuantityTextBox.Text = "";

        }
    }
}
