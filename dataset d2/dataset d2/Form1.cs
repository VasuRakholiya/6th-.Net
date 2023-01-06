using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataset_d2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"data source=DESKTOP-9QC0DO8; initial catalog=AdventureWorksDW2019;integrated security=true");
        DataSet ds= new DataSet();
        SqlDataAdapter ad1;
        DataTable dt=new DataTable();
        DataRow dr;
        int rn;
        private void Form1_Load(object sender, EventArgs e)
        {
            ad1 = new SqlDataAdapter("select *from student", con);
            ad1.Fill(ds, "ss");
            dt = ds.Tables["ss"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rn = 0;
            dr = dt.Rows[rn];
            textBox1.Text= dr[0].ToString();
            textBox2.Text= dr[1].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rn = rn + 1;
            if (rn < dt.Rows.Count - 1)
            {
                dr = dt.Rows[rn];
                textBox1.Text = dr[0].ToString();
                textBox2.Text = dr[1].ToString();
            }
            else
            {
                rn = rn - 1;
                MessageBox.Show("end");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rn = rn - 1;
            if (rn >= 0)
            {
                dr = dt.Rows[rn];
                textBox1.Text = dr[0].ToString();
                textBox2.Text = dr[1].ToString();
            }
            else
            {
               rn= rn + 1;
                MessageBox.Show("begining");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rn=dt.Rows.Count- 1;
            dr = dt.Rows[rn];
            textBox1.Text = dr[0].ToString();
            textBox2.Text = dr[1].ToString() ;
        }
    }
}
