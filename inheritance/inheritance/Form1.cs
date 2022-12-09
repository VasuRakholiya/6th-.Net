using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class first
        {
            public void car()
            {
                MessageBox.Show("car");
            }
            
        }
        class second : first
        {
            public void car2()
            {
                MessageBox.Show("car 2");
            }
        }
        class third : second
        {
            public void car3()
            {
                MessageBox.Show("car 3");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            third th= new third();
            th.car3();
            th.car2();
            th.car3();
        }
    }
}
