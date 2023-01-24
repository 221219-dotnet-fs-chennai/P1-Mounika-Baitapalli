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
         
        static string conStr = File.ReadAllText("../../../connectionstring.txt");
        ISqlRepo repo = new SqlRepo(conStr);
            public void Display()
            {
                Console.WriteLine("\n-------login Page------\n");
                Console.WriteLine("[M] To Go For Menu");
                Console.WriteLine("[1] to Proceed Login");
            }

            public string UserChoice()
            {
                
                Console.Write("\nEnter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "M":
                        return "Menu";
                    case "1":
                        Console.Write("\nEnter your Email ID: ");
                        string EmailId = Console.ReadLine();
                        bool login_obj = repo.Tlogin(EmailId);
                    
                        /*if (login_obj)
                        {
                            TSignUp trainesignup = new TSignUp(repo.GetAllTrainers(EmailId));

                            return "TrainerProfile";
                        }
                        else*/
                        
                            return "TUpdate";
                        

                    default:
                        Console.WriteLine("\n You have Entered a Wrong choice, try again...");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        return "Tlogin";
                }
            }
        }
    }


