using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTicketingApp
{
    class Flight
    {
        private static string firstFlight = "";
        private static string secondFlight = " ";
        private static string firstFlightTime = "";
        private static string secondFlightTime = "";
        private static string firstFlightPrice = "0";
        private static string secondFlightPrice = "0";
        private static string origion = "";
        private static string destination = "";


        public static string FirstFlight { set; get; }
        public static string SecondFlight { set; get; }

        public static string FirstFlightTime { set; get; }
        public static string SecondFlightTime { set; get; }

        public static string FirstFlightPrice { set; get; }
        public static string SecondFlightPrice { set; get; }

        public static string Origion { set; get; }
        public static string Destination { set; get; }
    }
}
