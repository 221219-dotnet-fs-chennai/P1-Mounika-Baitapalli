using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace TrainerProject
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Log.Logger = new LoggerConfiguration()
                .WriteTo.File(@"..\..\..\..\Logs\logs.txt", rollingInterval: RollingInterval.Day, rollOnFileSizeLimit: true)
                .CreateLogger();

            Log.Logger.Information("-------Program starts here-------");*/

            bool value = true;
           bool value_2 = true;

            IMenu menu = new Menu();

            while (value)
            {
                Console.Clear();
                menu.Display();
                
                string reply = menu.UserChoice();

                switch (reply)
                {
                    case "Menu":
                        Console.WriteLine("Display menu to the user");
                        menu = new Menu();
                        break;
                    case "Trainer's SignUp":
                        menu = new TSignUp();
                        break;

                    case "Exit":
                        Console.WriteLine("Thank you for using Online Trainer Application'");
                        Console.WriteLine("-------Program ends-------");
                       
                        value = false;
                        break;

                    default:
                        Console.WriteLine("\nDataBase Does not exist");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                        break;
                }
            }

        }
    }
}
    
           
        
   



    
        
        
    

