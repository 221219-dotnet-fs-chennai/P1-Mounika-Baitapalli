using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Trainer_Data;


namespace TrainerProject
{

    class Program
    {
        private static Details details = new Details();
        static void Main(string[] args)
        {
            /*Log.Logger = new LoggerConfiguration()
                .WriteTo.File(@"..\..\..\..\Logs\logs.txt", rollingInterval: RollingInterval.Day, rollOnFileSizeLimit: true)
                .CreateLogger();

            Log.Logger.Information("-------Program starts here-------");*/

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
                        Console.WriteLine("Display menu to the user");
                        menu = new Menu();
                        break;
                    case "Trainer's SignUp":
                        menu = new TSignUp();
                        break;

                    case "Trainer's Login":
                        Console.WriteLine("Select the Trainer which  likely the most");
                        menu = new Tlogin();
                        break;
                    case "Trainer_Profile":
                        Console.WriteLine("showing the Trainer's Profile");
                        
                        menu = new Trainer_Profile(details);
                        break;
                        
                        
                    /*while (value)
                    {

                        System.Console.Clear();
                        menu.Display();
                        string Choice = menu.UserChoice();

                        switch (Choice)
                        {
                            case "ShowDetails":
                                Console.WriteLine("user select showing details");
                                menu = new UserInteraction(details);
                                break;

*/
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
    

    
           
        
   



    
        
        
    

