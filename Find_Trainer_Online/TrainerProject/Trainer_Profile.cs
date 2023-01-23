using Trainer_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace TrainerProject
{
    class Trainer_Profile : IMenu
    {

        Details details = new Details();
        static string conStr = File.ReadAllText("../../../connectionstring.txt");
        SqlRepo repo = new SqlRepo(conStr);
        public Trainer_Profile(Details d)
        {
            details = d;
        }

        public void Display()
        {
            Console.WriteLine("Welcome to Trainer's Profile");
            Console.WriteLine("[M] Menu:");
            Console.WriteLine("[1] View Your Profile: ");
            Console.WriteLine("[2] Update Your Necessary information :");
            Console.WriteLine("[3] Delete Your information, you wish to delete:");
            Console.WriteLine("[E] Exit");
        }
        public string UserChoice()
        {
            string Input = Console.ReadLine();
            switch (Input)
            {
                case "M":
                    Console.WriteLine("Go To Menu page:");
                    return "Menu";
                case "1":
                    Console.WriteLine("Hello Mounika!,Welcome to  your Profile:");
                    Viewdetails();
                    Console.ReadLine();
                    return "Trainer_Profile";

                case "2":
                    Console.WriteLine("Update Your Necessary information:");
                    return "TUpdate";
                case "3":
                    Console.WriteLine("Delete Your information,you wish to delete");
                    return "TDelete";

                case "E":
                    Console.WriteLine("You Proceed to Exit?:(Yes/No)");
                    return "Exit";
                default:
                    Console.WriteLine("You have choosen InAppropriate choice!");
                    Console.WriteLine("Click enter to Continue:");
                    Console.WriteLine("Taking You to the Home page");
                    return "Menu";
            }


        }
        public void Viewdetails()
        {

            Console.WriteLine("---Welcome to signup---");
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


