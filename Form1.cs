using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blood_bank_management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((comboBox1.Text.CompareTo("DONOR") == 0) && (textBox1.Text.CompareTo("1234") == 0))
            {
                MessageBox.Show("Successfully logged in as donor");
                Donorpage d5 = new Donorpage();
                d5.Show();
            }
            else
                if((comboBox1.Text.CompareTo("HOSPITAL") == 0) && (textBox1.Text.CompareTo("6789") == 0))
            {
                MessageBox.Show("Successfully logged in as existing hospital");
                existinghospital d1 = new existinghospital();
                d1.Show();
            }

            else
            {
                MessageBox.Show("Username and password do not exist");

            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Donorpage d = new Donorpage();
            d.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            existinghospital e1 = new existinghospital();
            e1.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Stock s = new Stock();
            s.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Transaction t = new Transaction();
            t.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Doni m = new Doni();
            m.Show();
        }

        private void qUERY1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query1 q1 = new query1();
            q1.Show();

        }

        private void qUERY2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query2 q2 = new query2();
            q2.Show();
        }

        private void qUERY3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query3 q3 = new query3();
            q3.Show();
        }

        private void qUERY4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query4 q4 = new query4();
            q4.Show();
        }

        private void qUERY5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query5 q5 = new query5();
            q5.Show();
        }

        private void qUERY6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query6 q6 = new query6();
            q6.Show();
        }

        private void qUERY7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query7 q7 = new query7();
            q7.Show();
        }

        private void qUERY8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query8 q8 = new query8();
            q8.Show();
        }

        private void qUERY9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query9 q9 = new query9();
            q9.Show();
        }

        private void qUERY10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            query10 q10 = new query10();
            q10.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
