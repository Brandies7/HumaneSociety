using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class CustomerMenu
    {
        HumaneSocietyDataContext context = new HumaneSocietyDataContext();
        public Customer customer;
        public Phone_Number phoneNumber;
        public Address address;
        public Person person;

        public CustomerMenu()
        {
            customer = new Customer();
            phoneNumber = new Phone_Number();
            address = new Address();
            person = new Person();
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
                              "Choose '2' to Search For a Pet." + Environment.NewLine +
                              "Choose '3' to Make Payment.");
            string customerChoice = Console.ReadLine();
            switch (customerChoice)
            {
                case "1":
                    CreateProfile();
                    break;
                case "2":
                    SearchForPet();
                    break;
                case "3":
                    MakePayment();
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
            person.First_Name = Console.ReadLine();

            Console.WriteLine("Please enter your last name.");
            person.Last_Name = Console.ReadLine();

            Console.WriteLine("What is your date of birth?");
            person.Date_Of_Birth = Console.ReadLine();

            Console.WriteLine("Please enter your SSN. (Optinal)");
            person.SSN = Console.ReadLine();

            Console.WriteLine("What is your address?");
            address.Address1 = Console.ReadLine();

            Console.WriteLine("What city do you live in?");
            address.City = Console.ReadLine();

            Console.WriteLine("Please enter the state you live in.");
            address.State = Console.ReadLine();

            Console.WriteLine("What is your zip code?");
            address.Zip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your phone number.");
            phoneNumber.PhoneNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your email address.");
            person.EMail = Console.ReadLine();

            Console.WriteLine("What is your password?");
            person.Password = Console.ReadLine();

            context.Persons.InsertOnSubmit(person);
            context.Addresses.InsertOnSubmit(address);
            context.Phone_Numbers.InsertOnSubmit(phoneNumber);
            context.SubmitChanges();
        }

        public void SearchForPet()
        {
            Console.WriteLine(
                "How would you like to search for your new pet. Please choose from one of the search options below." + Environment.NewLine +
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
            Console.WriteLine("What age of pet are you looking for?");
            int animalAge = Convert.ToInt32(Console.ReadLine());
            var results =
            (from a in context.Animals
                where a.Age == animalAge
                select a).ToList();
            foreach (var row in results)
            {
                Console.WriteLine("These are the ages of the animals currently in our system" + row.Age);
                Console.ReadLine();
            }
        }

        public void AnimalSex()
        {
            Console.WriteLine("Are you looking for male or female?" + Environment.NewLine +
                              "Choose '1' For Male" + Environment.NewLine +
                              "Choose '2' For Female");
            string animalSex = Console.ReadLine();
            switch (animalSex)
            {
                case "1":
                    var results =
                    (from a in context.Animals
                        where a.Sex == animalSex
                        select a).ToList();
                    foreach (var row in results)
                    {
                        Console.WriteLine("These are the animals that match your search" + row.Species);
                        Console.ReadLine();
                    }
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
                    var results =
                    (from a in context.Animals
                        where a.Species == animalSpecies
                        select a).ToList();
                    foreach (var row in results)
                    {
                        Console.WriteLine("These are the different type of species currently in our system" +
                                          row.Species);
                        Console.ReadLine();
                    }
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
                    var results =
                    (from a in context.Animals
                        where a.Breed == animalBreed
                        select a).ToList();
                    foreach (var row in results)
                    {
                        Console.WriteLine("These are the breeds of animals currently in our system" + row.Breed);
                        Console.ReadLine();
                    }
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
            int animalPrice = Convert.ToInt32(Console.ReadLine());
            switch (animalPrice)
            {
                case 1:
                    var results =
                    (from a in context.Animals
                        where a.SalePrice == animalPrice
                        select a).ToList();
                    foreach (var row in results)
                    {
                        Console.WriteLine("These are the prices of the animals currently in our system" +
                                          row.SalePrice);
                        Console.ReadLine();
                    }

                    break;
                case 2:
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

        public void MakePayment()
        {
            Console.WriteLine("How much money would you like to pay");
            customer.Make_Payment = Console.ReadLine();

            context.Customers.InsertOnSubmit(customer);
            context.SubmitChanges();
        }
    }
}

        
  
