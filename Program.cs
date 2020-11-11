using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

using rentManagement.Models;



namespace rentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Your Rent Management System");
            Welcome();
        }

        private static void Welcome()
        {
            var rentManagementSystem = new RentManagementSystem();

            bool loopBreak = true;
            while (loopBreak)
            {
                Console.WriteLine($"\nENTER \nA: TO LIST ALL THE RENTAL APARTMENTS WITH STATUS, \nB: TO ADD A CUSTOMER,\nC: TO REMOVE A CUSTOMER,\nD: TO ASSIGN A UNIT, \nE: TO REASSIGN A UNIT, \nF: TO CHANGE THE COSTS OF THE APARTMENT, \nG: TO OPEN A COMPLAINT TICKET AT A UNIT, \nH: TO CLOSE THE COMPLAINT TICKET, \nQ: TO QUIT");
                var welcomeInput = Console.ReadLine().ToUpper();

                switch (welcomeInput)
                {
                    case "A":
                        Console.WriteLine("Getting the list......");
                        break;
                    case "B":
                        System.Console.WriteLine("Adding a customer.....");
                        rentManagementSystem.AddACustomer();
                        break;
                    case "C":
                        System.Console.WriteLine("Deleting a customer.....");
                        rentManagementSystem.DeleteACustomer();
                        break;
                    case "D":
                        System.Console.WriteLine("Assigning a Unit.....");
                        break;
                    case "E":
                        System.Console.WriteLine("Reassigning a Unit....");
                        break;
                    case "F":
                        System.Console.WriteLine("Changing the cost of the apartment units...");
                        break;
                    case "G":
                        System.Console.WriteLine("Issuing a complaint ticket");
                        break;
                    case "H":
                        System.Console.WriteLine("Closing a resolved complaint ticket....");
                        break;
                    case "Q":
                        System.Console.WriteLine("Thanks for using Rent Management, See You Again !");
                        loopBreak = false;
                        break;
                    default:
                        System.Console.WriteLine("Please enter a valid input");
                        break;
                }
            }
        }
    }
}
