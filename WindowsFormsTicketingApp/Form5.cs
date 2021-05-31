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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            label1.Text = Ticket.Title;
            label2.Text = Ticket.FirstName + " " + Ticket.LastName;
            label3.Text = Ticket.Origion;
            label4.Text = Ticket.Destination;
            label5.Text = Ticket.FirstFlight;
            label6.Text = Ticket.FirstFlightTime;
            label7.Text = Ticket.SecondFlight;
            label8.Text = Ticket.SecondFlightTime;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
