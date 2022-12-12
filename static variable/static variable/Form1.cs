using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace static_variable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class join
        {
            static int balance = 10000;
            public void withdraw(int amt)
            {
                balance=balance-amt;
                MessageBox.Show("the current balance is" + balance);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            join j= new join();
            j.withdraw(Convert.ToInt32(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            join j = new join();
            j.withdraw(Convert.ToInt32(textBox1.Text));
        }
    }
}
