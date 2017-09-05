using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class HumaneSocietyUI
    {
        public CustomerMenu customer;
        public EmployeeMenu employee;

        public HumaneSocietyUI()
        {
            employee = new EmployeeMenu();
            customer = new CustomerMenu();
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Welcome to the Racine County Humane Society." + Environment.NewLine + 
                              "Please press '1' if you are a customer or '2' if you are an employee.");
            string menuOption = Console.ReadLine();
            switch (menuOption)
            {
                case "1":
                    customer.GetCustomerName();
                    break;
                case "2":
                    GetEmployeeID();
                    break;
                default:
                    Console.WriteLine("That is an invalid option, please try again.");
                    DisplayMenu();
                    break;
            }
        }

        public void GetEmployeeID()
        {
            Console.WriteLine("Please enter your employee ID number");
            string employeeID = Console.ReadLine();
            switch (employeeID)
            {
                case "1111":
                    employee.DisplayEmployeeMenu();
                    break;
                case "2222":
                    employee.DisplayEmployeeMenu();
                    break;
                case "3333":
                    employee.DisplayEmployeeMenu();
                    break;
                case "4444":
                    employee.DisplayEmployeeMenu();
                    break;
                case "5555":
                    employee.DisplayEmployeeMenu();
                    break;
                default:
                    Console.WriteLine("Sorry, but we do not have any employee's with that ID number. Please try again.");
                    GetEmployeeID();
                    break;
            }
        }
    }
}
            
                    
            
        
        
               
        


            
                    
            
 
