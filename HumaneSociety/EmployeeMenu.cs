using System;
using System.Collections.Generic;
using System.Linq;
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
            animal.Food_Intake = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What room number will this animal be assigned?");
            animal.Room_Number = Convert.ToInt32(Console.ReadLine());

            context.Animals.InsertOnSubmit(animal);



        }

        public void UpdateRoomNumber()  
        {
            
        }

        public void AdoptionStatus()
        {
            
        }

        public void VaccinationRecords()
        {
            
        }

        public void FoodIntake()
        {
            
        }
    }
}
