using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class CustomerMenu
    {
        HumaneSocietyDataContext context = new HumaneSocietyDataContext();
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
                              "Choose '1' for Age" + Environment.NewLine +
                              "Choose '2' for Sex" + Environment.NewLine +
                              "Choose '3' for Species" + Environment.NewLine +
                              "Choose '4' for Breed" + Environment.NewLine +
                              "Choose '5' for Price" + Environment.NewLine +
                              "Choose '6' for All Pet Information");
            string searchChoice = Console.ReadLine();
            switch (searchChoice)
            {
                case "1":
                    AnimalAge();
                    break;
                case "2":
                    AnimalSex();
                    break;
                case "3":
                    AnimalSpecies();
                    break;
                case "4":
                    AnimalBreed();
                    break;
                case "5":
                    AnimalPrice();
                    break;
                case "6":
                    AnimalInfo();
                    break;

                default:
                    Console.WriteLine("Sorry, that was an invalid entry. Please try again.");
                    SearchForPet();
                    break;
            }
        }

        public void AnimalAge()
        {
            Console.WriteLine("Would you like to display the results or refine your search?" + Environment.NewLine +
                              "Choose '1' to Display Results." + Environment.NewLine +
                              "Choose '2' to Refine Search");
            string animalAge = Console.ReadLine();
            switch (animalAge)
            {
                case "1":
                    //display results
                    break;
                case "2":
                    SearchForPet();
                    break;
                default:
                    Console.WriteLine("Not a valid entry. Please try again");
                    break;
            }
        }

        public void AnimalSex()
        {
            Console.WriteLine("Would you like to display the results or refine your search?" + Environment.NewLine +
                              "Choose '1' to Display Results." + Environment.NewLine +
                              "Choose '2' to Refine Search");
            string animalSex = Console.ReadLine();
            switch (animalSex)
            {
                case "1":
                    //display results
                    break;
                case "2":
                    SearchForPet();
                    break;
                default:
                    Console.WriteLine("Not a valid entry. Please try again");
                    break;
            }
        }

        public void AnimalSpecies()
        {
            Console.WriteLine("Would you like to display the results or refine your search?" + Environment.NewLine +
                              "Choose '1' to Display Results." + Environment.NewLine +
                              "Choose '2' to Refine Search");
            string animalSpecies = Console.ReadLine();
            switch (animalSpecies)
            {
                case "1":
                    //display results
                    break;
                case "2":
                    SearchForPet();
                    break;
                default:
                    Console.WriteLine("Not a valid entry. Please try again");
                    break;
            }
        }

        public void AnimalBreed()
        {
            Console.WriteLine("Would you like to display the results or refine your search?" + Environment.NewLine +
                              "Choose '1' to Display Results." + Environment.NewLine +
                              "Choose '2' to Refine Search");
            string animalBreed = Console.ReadLine();
            switch (animalBreed)
            {
                case "1":
                    //display results
                    break;
                case "2":
                    SearchForPet();
                    break;
                default:
                    Console.WriteLine("Not a valid entry. Please try again");
                    break;
            }
        }

        public void AnimalPrice()
        {
            Console.WriteLine("Would you like to display the results or refine your search?" + Environment.NewLine +
                              "Choose '1' to Display Results." + Environment.NewLine +
                              "Choose '2' to Refine Search");
            string animalPrice = Console.ReadLine();
            switch (animalPrice)
            {
                case "1":
                    var results =
                        
                        
                        
                    break;
                case "2":
                    SearchForPet();
                    break;
                default:
                    Console.WriteLine("Not a valid entry. Please try again");
                    break;
            }
        }

        public void AnimalInfo()
        {
            var results =
                from a in context.Animals
                select a;
            Console.WriteLine(results);
            Console.ReadLine();
        }
    }
}
