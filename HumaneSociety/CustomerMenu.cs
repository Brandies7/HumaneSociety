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
            Console.WriteLine("Please enter your first name.");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name.");
            string lastName = Console.ReadLine();

            Console.WriteLine("What is your date of birth?");
            string birthDate = Console.ReadLine();

            Console.WriteLine("Please enter your SSN. (Optinal)");
            string socialSecurity = Console.ReadLine();

            Console.WriteLine("What is your address?");
            string address = Console.ReadLine();

            Console.WriteLine("What city do you live in?");
            string city = Console.ReadLine();

            Console.WriteLine("Please enter the state you live in.");
            string state = Console.ReadLine();

            Console.WriteLine("What is your zip code?");
            string zipCode = Console.ReadLine();

            Console.WriteLine("Please enter your phone number.");
            string phoneNumber = Console.ReadLine();

        }

        public void SearchForPet()
        {
            Console.WriteLine("How would you like to search for your new pet. Please choose from one of the search options below." + Environment.NewLine +
                              "");
        }
    }
}
