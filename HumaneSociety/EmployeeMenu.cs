using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class EmployeeMenu
    {
        Animal animal = new Animal();
        HumaneSocietyDataContext context = new HumaneSocietyDataContext();
        public EmployeeMenu()
        {
            
        }

        public void DisplayEmployeeMenu()
        {
            Console.WriteLine("Welcome back to work, what would you like to do today?" + Environment.NewLine +
                              "Choose '1' to Add New Animal." + Environment.NewLine +
                              "Choose '2' to Update Room Number." + Environment.NewLine +
                              "Choose '3' to Update Adoption Status." + Environment.NewLine +
                              "Choose '4' to Update Vaccination Records." + Environment.NewLine +
                              "Choose '5' to Update Animals Fodd Intake.");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddAnimal();
                    break;
                case "2":
                    UpdateRoomNumber();
                    break;
                case "3":
                    AdoptionStatus();
                    break;
                case "4":
                    VaccinationRecords();
                    break;
                case "5":
                    FoodIntake();
                    break;
                default:
                    Console.WriteLine("Sorry, that was an invalid entry. Please try again.");
                    DisplayEmployeeMenu();
                    break;
            }
        }

        public void AddAnimal()
        {
            Console.WriteLine("Please enter the animals name.");
            animal.Name = Console.ReadLine();

            Console.WriteLine("What is the gender of the animal?");
            animal.Sex = Console.ReadLine();

            Console.WriteLine("What species is this animal?");
            animal.Species = Console.ReadLine();

            Console.WriteLine("What is the breed of the animal?");
            animal.Breed = Console.ReadLine();

            Console.WriteLine("Is this animal up to date on its vaccines?");
            animal.Vaccinated = Console.ReadLine();

            Console.WriteLine("Has the animal been spayed/neutered?");
            animal.SpayedorNeutered = Console.ReadLine();

            Console.WriteLine("How much does this animal cost?");
            animal.SalePrice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many pounds of food does this animal eat per day?");
            animal.Food_Intake = Console.ReadLine();

            Console.WriteLine("What room number will this animal be assigned?");
            animal.Room_Number = Console.ReadLine();

            context.Animals.InsertOnSubmit(animal);
            context.SubmitChanges();
            AddAnotherAnimal();
        }

        public void AddAnotherAnimal()
        {
            Console.WriteLine("What would you like to do next?" + Environment.NewLine +
                              "Enter '1' to Add Another Animal" + Environment.NewLine +
                              "Enter '2' to Go Back to Main Menu" + Environment.NewLine +
                              "Enter '3' to Exit");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    AddAnimal();
                    break;
                case "2":
                    DisplayEmployeeMenu();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Sorry, but you must choose one of the options given");
                    AddAnotherAnimal();
                    break;
                    
            }
        }

        public void UpdateRoomNumber()  
        {
            
            Console.WriteLine("What is the name of the animal that you would like to update room number for?");
            animal.Name = Console.ReadLine();

            Console.WriteLine("What would you like the new room number to be for " + animal.Name + "?");
            animal.Room_Number = Console.ReadLine();

            var results =
            (from a in context.Animals
                where a.Room_Number.Contains(animal.Room_Number)
                select a).First();

            results.Room_Number = animal.Room_Number;
            context.SubmitChanges();
        }

        public void AdoptionStatus()
        {
            Adoption_Status adoptionStatus = new Adoption_Status();

            Console.WriteLine("What is the name of the animal that you would like to change adoption status for?");
            animal.Name = Console.ReadLine();

            Console.WriteLine("What is the updated adoption status of " + animal.Name + "?");
            adoptionStatus.Adopted = Console.ReadLine();

            var results =
            (from a in context.Adoption_Status
                where a.Adopted.Contains(adoptionStatus.Adopted)
                select a).First();

            results.Adopted = adoptionStatus.Adopted;
            context.SubmitChanges();
        }

        public void VaccinationRecords()
        {
            Console.WriteLine("What is the name of the animal you would like to update vaccination record for?");
            animal.Name = Console.ReadLine();

            Console.WriteLine("What is the updated vaccination status for " + animal.Name + "?");
            animal.Vaccinated = Console.ReadLine();

            var results =
            (from a in context.Animals
                where a.Vaccinated.Contains(animal.Vaccinated)
                select a).First();

            results.Vaccinated = animal.Vaccinated;
            context.SubmitChanges();
        }

        public void FoodIntake()
        {
            Console.WriteLine("What is the name of the animal that you would like to update food intake for?");
            animal.Name = Console.ReadLine();

            Console.WriteLine("What is the new food intake for " + animal.Name + " (in pounds)?");
            animal.Food_Intake = (Console.ReadLine());

            var results =
            (from a in context.Animals
                where a.Food_Intake.Contains(animal.Food_Intake)
                select a).First();

            results.Food_Intake = animal.Food_Intake;
            context.SubmitChanges();
        }
    }
}
