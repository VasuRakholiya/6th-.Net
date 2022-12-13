using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace error_handling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = a / b;
                textBox3.Text = c.ToString();
            }
            catch(DivideByZeroException cc) {
                MessageBox.Show("cant divide by zero" + cc.Message);
            }
            catch(FormatException cc)
            {
                MessageBox.Show("dont enter characters" + cc.Message);
            }
            catch(Exception cc)
            {
                MessageBox.Show("some genral error come" + cc.Message);
            }
            finally
            {
                MessageBox.Show("i am alive");
            }
        }
        class Axisbank:ApplicationException
        {
            public Axisbank(string message):base(message)
            {

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int age=Convert.ToInt32(textBox4.Text);
                if(age<18)
                {
                    throw new Axisbank("abe below 18 can not open account");
                }
            }
            catch(Axisbank cc)
            {
                MessageBox.Show(cc.Message);
            }
        }
    }
}
