using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainer_Data;

namespace TrainerProject
{
    public class Tlogin : IMenu
    {
         static string conStr = File.ReadAllText("../../connectionString.txt");

         SqlRepo repo = new SqlRepo(conStr);
            public void Display()
            {
                Console.WriteLine("\n-------LOGIN PAGE------\n");
                Console.WriteLine("[0] To Go For Menu");
                Console.WriteLine("[1] to Proceed Login");
            }

            public string UserChoice()
            {
                Console.WriteLine("\n---------------------------");
                Console.Write("\nEnter your choice: ");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "0":
                        return "TrainerMenu";
                    /*case "1":
                        Console.Write("\nEnter your Email ID: ");
                        string eMail = Console.ReadLine();
                        bool login = repo.Tlogin(eMail);
                        if (login)
                        {
                            TSignUp trainerLogin = new   TSignUp(repo.GetAllTrainerList(eMail));
                            return "TrainerProfile";
                        }
                        else
                        {
                            return "Login";
                        }*/

                    default:
                        Console.WriteLine("\nWrong choice try again...");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        return "Login";
                }
            }
        }
    }


