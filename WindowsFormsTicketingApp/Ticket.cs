using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTicketingApp
{
    class Ticket:Flight
    {


        private static string title = "";
        private static string firstName = "";
        private static string lastName = "";
        private static int totalPrice;



        public static string Title { set; get; }
        public static string FirstName { set; get; }
        public static string LastName { set; get; }

        public static int Totalprice { set; get; }
    }
}
