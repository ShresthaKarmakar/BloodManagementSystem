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
    public partial class existinghospital : Form
    {
        string con_string = "Data Source= 192.168.43.160,49170;Initial Catalog=blood_bank_management_system;User ID=sa;Password=come@12";
        SqlConnection con;
        public existinghospital()
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
                SqlDataAdapter sda2 = new SqlDataAdapter("select hid,name,place,qty,bloodtype,sids from hospital", con);
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

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doni d = new Doni();
            d.Show();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                con.Open();
                SqlDataAdapter sda2 = new SqlDataAdapter("select rid,fname,lname,age from donor where rid like ('" + textBox6.Text + "%')", con);
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

    }
}

