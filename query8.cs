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
    public partial class query8 : Form
    {
        string con_string = "Data Source= 192.168.43.160,49170;Initial Catalog=blood_bank_management_system;User ID=sa;Password=come@12";
        SqlConnection con;
        public query8()
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
                SqlDataAdapter sda2 = new SqlDataAdapter("select d1.fname,d1.lname from donor1 d1 where d1.age>(select d2.age from doni d2 where d2.reason='Dialysis' and d1.sids=d2.sids)", con);
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

        private void qUERY9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query9 q9 = new query9();
            q9.Show();
        }
    }
    
}

