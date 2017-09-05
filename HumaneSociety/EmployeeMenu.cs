using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class EmployeeMenu
    {
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
