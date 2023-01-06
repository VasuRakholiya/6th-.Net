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

namespace dataset_d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"data source=DESKTOP-9QC0DO8;initial catalog=AdventureWorksDW2019;"+"Integrated Security=true");
        SqlDataAdapter ad1;
        SqlDataAdapter ad2;
        DataSet ds= new DataSet();
        private void dataGrid1_Navigate(object sender, NavigateEventArgs ne)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ad1 = new SqlDataAdapter("select * from DimEmployee", con);
            ad2 = new SqlDataAdapter("select * from DimCustomer", con);
            ad1.Fill(ds, "ee");
            ad2.Fill(ds, "cc");
            dataGrid1.DataSource = ds;
        }
    }
}
