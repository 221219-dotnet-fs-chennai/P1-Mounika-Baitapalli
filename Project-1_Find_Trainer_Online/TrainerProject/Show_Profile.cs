using Serilog;
using System.Xml.Linq;
using Trainer_Data;
using TrainerProject;

namespace Console1
{
    class Show_Profile : IMenu
    {

        Details details = new Details();
        static string conStr = File.ReadAllText("../../../connectionstring.txt");
        SqlRepo repo = new SqlRepo(conStr);

        public Show_Profile()
        {

        }
        string Email;
        public Show_Profile(Details d)
        {
            details = d;
        }

        public void Display()
        {
            System.Console.WriteLine($"Welcome {details.Name} :)");
            System.Console.WriteLine("Choose below options to perform actions\n");
            System.Console.WriteLine("[0] to Back");
            System.Console.WriteLine("[1] For to get Trainer_details");
            System.Console.WriteLine("[2] For to get Trainer Educational_details");
            System.Console.WriteLine("[3] For to get Trainer Skill_Set");
            System.Console.WriteLine("[4] For to get Trainer Company_Details");
        }
        public string UserChoice()
        {

            System.Console.Write("\nEnter your choice: ");
            string obj7 = System.Console.ReadLine();

            switch (obj7)
            {
                case "0":
                    return "TUpdate";
                case "1":

                    System.Console.WriteLine("showing Trainer_Details...");
                    Profile("1");
                    System.Console.ReadLine();
                    return "ShowDetails";
                case "2":

                    System.Console.WriteLine("Showing trainer's Company_Details...");
                    Profile("2");
                    System.Console.ReadLine();
                    return "Show_Profile";
                case "3":

                    System.Console.WriteLine("Showing trainer's Skill_Set...");
                    Profile("3");
                    System.Console.ReadLine();
                    return "Show_Profile";
                case "4":

                    System.Console.WriteLine("Showing trainer's Education_Details..");
                    Profile("4");
                    System.Console.ReadLine();
                    return "Show_Profile";
                default:
                    System.Console.WriteLine("You have entered a Wrong choice ,so please try again");
                    System.Console.WriteLine("Press Enter to continue");
                    System.Console.ReadLine();
                    return "Show_Profile";
            }
        }

        public void Profile(string obj)
        {
            Log.Logger.Information("Reading Trainer Details");

            if (obj == "1")
            {
                System.Console.WriteLine("[1] Name                     : " + details.Name);
                System.Console.WriteLine("[2] Age                      : " + details.Age);
                System.Console.WriteLine("[3] Gender                   : " + details.Gender);
                System.Console.WriteLine("[4] EmailId                  : " + details.EmailId);
                System.Console.WriteLine("[5] Password                 : " + details.Password);
                System.Console.WriteLine("[6] Contact_Number           : " + details.Contact_Number);
                System.Console.WriteLine("[7] Location                 : " + details.Location);
                System.Console.WriteLine("[8] SocialMedia_Profile      : " + details.SocialMedia_Profile);
                System.Console.WriteLine("[9]Skill_1                  : " + details.Skill_1);
                System.Console.WriteLine("[10]Skill_2                  : " + details.Skill_2);
                System.Console.WriteLine("[11]Skill_3                  : " + details.Skill_3);
                System.Console.WriteLine("[12] Company_Name            : " + details.Company_Name);
                System.Console.WriteLine("[13] Experience_In_Years     : " + details.Experience_In_Years);
                System.Console.WriteLine("[14]Position                 : " + details.Position);
                System.Console.WriteLine("[15]Institution              : " + details.Institution);
                System.Console.WriteLine("[16] Degree                  : " + details.Degree);
                System.Console.WriteLine("[17]Specialization           : " + details.Specialization);
                System.Console.WriteLine("[18] Year_Of_Passing         : " + details.Year_Of_Passing);
            }


        }
    }
}


