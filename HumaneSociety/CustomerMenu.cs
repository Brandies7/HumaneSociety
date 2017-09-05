using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Customers
    {
        public Customers()
        {
            
        }

        public void GetCustomerName()
        {
            Console.WriteLine("Please enter your name");
            string customerName = Console.ReadLine();
            DisplayCustomerMenu(customerName);
        }

        public void DisplayCustomerMenu(string customerName)
        {
            Console.WriteLine("Hello " + customerName + ", how can we help you? Please choose from one of the following options:" + Environment.NewLine +
                              "");
            Console.ReadLine();

        }
    }
}
