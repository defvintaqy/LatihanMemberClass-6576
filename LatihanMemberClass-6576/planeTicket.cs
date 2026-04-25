//25.11.6576
using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanMemberClass_6576
{
    internal class planeTicket
    {
        //propperti
        public string origin;
        public string destination;
        public int cost;
        public string currency;

        //method
        public void PrintSummary()
        {
            Console.WriteLine("Origin:" + origin);
            Console.WriteLine("Destination: " + destination);
            Console.WriteLine("Cost:" + cost + " (" + currency + ")");

            if(currency == "USD")
            {
                int idr = cost * 15000;
                Console.WriteLine("Convert to Rupiah: " +idr);
            }
            else if (currency == "IDR")
            {
                int usd = cost / 15000;
                Console.WriteLine("Convert to Dollar:" +usd);
            }

            Console.WriteLine();
        }
    }
}
