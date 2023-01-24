using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Trainer_Data;


namespace TrainerProject
{

    class Program : TSignUp
    {
       // private static Details details = new Details();
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.File(@"..\..\..\logs.txt", rollingInterval: RollingInterval.Day, rollOnFileSizeLimit: true)
                .CreateLogger();

            Log.Logger.Information("-------Program starts here-------");

            bool boolean = true;
            //bool value_2 = true;

            IMenu menu = new Menu();

            while (boolean)
            {

                menu.Display();

                string obj = menu.UserChoice();

                switch (obj)
                {
                    case "Menu":
                        Log.Logger.Information("Trainers enter into menu page");
                        Console.WriteLine("Display menu to the user");
                        menu = new Menu();
                        break;
                    case "Trainer's SignUp":
                        menu = new TSignUp();
                        break;

                    case "Trainer's Login":
                        Log.Logger.Information("this is into the login page");
                        Console.WriteLine("Select the Trainer which  likely the most");
                        menu = new Tlogin();
                        break;
                    case "Trainer_Profile":
                        Console.WriteLine("showing the Trainer's Profile");
                        
                        menu = new Trainer_Profile(details);
                        break;
                    case "TUpdate":
                        Console.WriteLine("updating the trainer details");
                        menu = new TUpdate(details);
                        break;
                    case "TDelete":
                        Console.WriteLine("Delete  the profile which user wish to delete");
                        menu = new TDelete(details);
                        break;
                    case "view":
                        menu = new GetTrainersList();
                        break;
                    case "ShowDetails":
                       Console.WriteLine("user select showing details");
                        menu = new TUpdate();
                        break;


                    case "Exit":
                        
                        Console.WriteLine("Thank you for using Online Trainer Application'");
                        Console.WriteLine("-------Program ends-------");

                        boolean = false;
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
    

    
           
        
   



    
        
        
    

