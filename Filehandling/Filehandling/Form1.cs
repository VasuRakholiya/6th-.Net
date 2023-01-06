using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Filehandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.ForeColor = colorDialog1.Color;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.BackColor = colorDialog1.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res = fontDialog1.ShowDialog();
            if(res==DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }
        FileStream fs;
        StreamReader sr;
        StreamWriter sw;
        private void button4_Click(object sender, EventArgs e)// writing in file 
        {
            DialogResult res=saveFileDialog1.ShowDialog();
            if(res==DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;//whatever file u select 
                fs = new FileStream(filename, FileMode.Create);// create and write it inside
                sw = new StreamWriter(fs);
                sw.Write(textBox1.Text);
                sw.Flush();// remove earlier data in file if at all it exsists
            }
        }
       private void button5_Click(object sender, EventArgs e)// to read the file 
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if(res==DialogResult.OK)
            {
                string filename2 = openFileDialog1.FileName;
                fs = new FileStream(filename2, FileMode.Open);// point to file 
                sr = new StreamReader(fs);// put the file into reader class 
                textBox1.Text = sr.ReadToEnd();// read till end into the text box 
            }

        }
    }
}
