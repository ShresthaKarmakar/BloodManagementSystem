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
    public partial class Doni : Form
    {
        string con_string = "Data Source=192.168.43.160,49170;Initial Catalog=blood_bank_management_system;User ID=sa;Password=come@12";
        SqlConnection con;

        public Doni()
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
                SqlDataAdapter sda2 = new SqlDataAdapter("select did,fname,lname,sex,age,bloodtype,reason,qty,date_received,place,sids from doni", con);
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




        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox8.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            textBox9.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            textBox10.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "insert into doni (did,fname,lname,sex,age,bloodtype,reason,qty,date_received,place,sids) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "' , '" + comboBox2.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "')";
           
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
           
            sda.SelectCommand.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Message successfully inserted");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transaction t = new Transaction();
            t.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();

        }
    }
}
