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
    public partial class Form3 : Form
    {
        public Form3()
        {
            Task task = new Task(doWork);
            InitializeComponent();
            task.Start();
  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
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
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void doWork()
        {
            label4.Text = Ticket.FirstFlight;
            label5.Text = Ticket.SecondFlight;
            label8.Text = Ticket.FirstFlightTime;
            label9.Text = Ticket.SecondFlightTime;
            label12.Text = Ticket.FirstFlightPrice;
            label13.Text = Ticket.SecondFlightPrice;
            label11.Text = "$" + Ticket.Totalprice.ToString();
        }
    }
}
