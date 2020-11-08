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
    public partial class query3 : Form
    {
        string con_string = "Data Source= 192.168.43.160,49170;Initial Catalog=blood_bank_management_system;User ID=sa;Password=come@12";
        SqlConnection con;

        public query3()
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
                SqlDataAdapter sda2 = new SqlDataAdapter("select d.fname from donor1 d where d.sids in ((select h.sids from hospital h, transac t where h.hid = t.hid and t.balance = 0)) and d.wgt > all(select avg(d2.wgt) from donor1 d2)", con);
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

        private void qUERY4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query4 q4 = new query4();
            q4.Show();
        }
    }
}
