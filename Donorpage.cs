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
    public partial class Donorpage : Form
    {
        string con_string = "Data Source=192.168.43.160,49170;Initial Catalog=blood_bank_management_system;User ID=sa;Password=come@12";
        SqlConnection con;

        public Donorpage()
        {
            con = new SqlConnection(con_string);
            InitializeComponent();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void Donorpage_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "insert into stock (sids,bloodtype,qty) values('" + textBox11.Text + "','" + textBox4.Text + "','" + textBox7.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            String query2 = "insert into donor1 (rid,fname,lname,age,sex,bloodtype,disease,qty,wgt,donated_on,place,sids) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox3.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox11.Text + "')";
            SqlDataAdapter sda1 = new SqlDataAdapter(query2, con);
            sda.SelectCommand.ExecuteNonQuery();
            sda1.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Message successfully inserted");

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
