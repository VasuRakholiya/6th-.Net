using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mouse_move
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x, y;
        int i, j;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(i<x)
            {
                pictureBox1.Location= new Point(i, j);
                i++;
            }
            else
            {
                pictureBox1.Location= new Point(i, j);
                i--;
            }
            if (j < y)
            {
                pictureBox1.Location = new Point(i, j);
                j++;
            }
            else
            {
                pictureBox1.Location = new Point(i, j);
                y--;
            }

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;

        }
    }
}
