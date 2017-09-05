using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class CustomerMenu
    {
        public CustomerMenu()
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
                              "Choose '1' to Create Profile." + Environment.NewLine +
                              "Choose '2' to Search For a Pet.");
            string customerChoice = Console.ReadLine();
            switch (customerChoice)
            {
                case "1":
                    CreateProfile();
                    break;
                case "2":
                    SearchForPet();
                    break;
                default:
                    Console.WriteLine("Sorry, that entry was not recognized. Please try again.");
                    DisplayCustomerMenu(customerName);
                    break;      
            }


        }

        public void CreateProfile()
        {
            
        }

        public void SearchForPet()
        {
            
        }
    }
}
