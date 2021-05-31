using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTicketingApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            //int total = int.Parse(Ticket.FirstFlightPrice) + int.Parse(Ticket.SecondFlightPrice);
            label6.Text = "$" + Ticket.Totalprice.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("Give your credit card number!! ;-)");
            }
            else if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("I need your first name!! ;-)");
            }
            else if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("I need your last name!! ;-)");
            }
            else
            {
                Ticket.Title = comboBox1.Text;
                Ticket.FirstName = textBox1.Text;
                Ticket.LastName = textBox2.Text;
                this.Hide();
                Form5 f5 = new Form5();
                f5.Show();

            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

    }
}
