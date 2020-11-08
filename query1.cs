using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace blood_bank_management_system
{
    public partial class query1 : Form
    {

        string con_string = "Data Source= 192.168.43.160,49170;Initial Catalog=blood_bank_management_system;User ID=sa;Password=come@12";
        SqlConnection con;


        public query1()
        {
            con = new SqlConnection(con_string);
            InitializeComponent();
            loadData();


        }

        public void loadData()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda2 = new SqlDataAdapter("select d1.fname from doni d1 where sids in (select sids from hospital where hid in (select h.hid from donor1 d2,hospital h,doni d where d2.sids=d.sids and d2.sids=h.sids and d2.wgt>=50))", con);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                BindingSource bs2 = new BindingSource();
                bs2.DataSource = dt2;
                dataGridView1.DataSource = bs2;
                sda2.Update(dt2);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void qUERY2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query2 q2 = new query2();
            q2.Show();
        }
    }
}
