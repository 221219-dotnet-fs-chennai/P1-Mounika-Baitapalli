using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerProject
{
    internal class Menu :IMenu
    {
        public void Display()
        {
            Console.WriteLine("\nWelcome to the Online Trainers Application ...\n\nSelect an option to proceed...");
            //Console.WriteLine(" Press[3] to Get Trainers List");
            Console.WriteLine("Press[2] to Trainer  Login");
            Console.WriteLine("Press[1] to Trainer  SignUp");
            Console.WriteLine("Press[E] to exit ");
            //Console.Write("\nPress [0] to Exit\nPress [1] to Get Trainers List\nPress [2] to Trainer Login or Signup");
        }

        public string UserChoice()
        {
            Console.WriteLine("\n---------------------------");
            Console.Write("\nEnter your choice: ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "E":
                    return "Exit";
                case "1":
                    return "Trainer's SignUp";
                case "2":
                    return "Trainer's Login";
                case "3":
                    return "Get Trainers List";
                default:
                    Console.WriteLine("You have entered a Wrong choice, Try Again!");
                    Console.WriteLine("Enter to continue");
                    Console.ReadLine();

                    return "Menu";
            }
        }
    }
}

