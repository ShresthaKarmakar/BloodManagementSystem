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
    public partial class query7 : Form
    {
        string con_string = "Data Source=192.168.43.160,49170;Initial Catalog=blood_bank_management_system;User ID=sa;Password=come@12";
        SqlConnection con;
        public query7()
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
                SqlDataAdapter sda2 = new SqlDataAdapter("select d.fname, d1.fname from donor1 d, doni d1 where d.sids = d1.sids and d.sex = 'F' and(d.age between 30 and 50) and d.sids in (select d1.sids from doni d1 where d1.sex = 'M')", con);
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

        private void qUERY8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query8 q8 = new query8();
            q8.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}
