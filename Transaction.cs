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
    public partial class Transaction : Form
    {
        string con_string = "Data Source=192.168.43.160,49170;Initial Catalog=blood_bank_management_system;User ID=sa;Password=come@12";
        SqlConnection con;

        public Transaction()
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
                SqlDataAdapter sda2 = new SqlDataAdapter("select hid,bloodtype,cost_per_unit,orders,total_cost,paid,balance from transac", con);
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


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comboBox3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox8.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                con.Open();
                SqlDataAdapter sda2 = new SqlDataAdapter("select rid,fname,lname,age from donor where rid like ('" + textBox3.Text + "%')", con);
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

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "insert into transac (hid,bloodtype,cost_per_unit,orders,total_cost,paid,balance) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";
            String query1 = "update stock set qty=0 where bloodtype='" + textBox2.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            
            sda.SelectCommand.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Payment done successfully!! ThankYou!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "update transac set balance='"+textBox8.Text+"' where hid='"+textBox1.Text+"' and bloodtype='"+textBox2.Text+"' and orders='"+comboBox2.Text+"'";
            String query1 = "update transac set paid='" + textBox7.Text + "' where hid='" + textBox1.Text + "' and bloodtype='" + textBox2.Text + "' and orders='"+comboBox2.Text+"'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
            sda.SelectCommand.ExecuteNonQuery();
            sda1.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Balance updated and payment done!! Thank You!");
        }
    }
}
