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
    public partial class query2 : Form
    {
        string con_string = "Data Source=192.168.43.160,49170;Initial Catalog=blood_bank_management_system;User ID=sa;Password=come@12";
        SqlConnection con;

        public query2()
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
                SqlDataAdapter sda2 = new SqlDataAdapter("select d.fname from donor1 d where sids in ((select sids from donor1) except (select sids from doni	where reason='anamia')) and d.place<>'Bangalore'", con);
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

        private void qUERY3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query3 q3 = new query3();
            q3.Show();
        }
    }
}
