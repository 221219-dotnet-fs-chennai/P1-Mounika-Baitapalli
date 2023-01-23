using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Trainer_Data;

namespace TrainerProject 
{
    internal class TUpdate: TSignUp, IMenu
{
        static string conStr = File.ReadAllText("../../../connectionstring.txt");
        SqlRepo repo = new SqlRepo(conStr);
    public TUpdate() { }
    public void Display()
    {
            System.Console.Clear();
            Console.WriteLine("[0] for to show profile data");
            Console.WriteLine("[1] for to update details");
            Console.WriteLine("[2] for to delete details");
            Console.WriteLine("[5] To for logout");

        }
        public string UserChoice()
        {
            System.Console.WriteLine("--------------------------");
            System.Console.Write("\nEnter your choice: ");
            int obj = Convert.ToInt32(Console.ReadLine());
            if (obj == 0)
            {
                return "ShowDetails";
            }
            if (obj == 1)
            {
                Console.Clear();
                Console.WriteLine("UPDATE DETAILS ");
                Console.WriteLine("[0] To go Back");
                Console.WriteLine("[1] To Update Trainer_Details");
                Console.WriteLine("[2] To Update Skill_Set");
                Console.WriteLine("[3] To Update Company_Details");
                Console.WriteLine("[4] To Update Education_Details");
                System.Console.WriteLine("\nselect an option to update or go back\n");
                string name = Console.ReadLine();
                if (name == "0")
                {
                    Console.Clear();
                    return "TrainerUpdate";
                }
                if (name == "1")
                {
                    System.Console.WriteLine("[0] Go Back             : ");
                    System.Console.WriteLine("[1] Password            : " + details.PASSWORD);
                    System.Console.WriteLine("[2] Fullname            : " + details.Full_name);
                    System.Console.WriteLine("[3] Age                 : " + details.Age);
                    System.Console.WriteLine("[4] Gender              : " + details.Gender);
                    System.Console.WriteLine("[5] Phone number        : " + details.Mobile_number);
                    System.Console.WriteLine("[6] Website             : " + details.Website);
                }
                if (name == "2")
                {
                    System.Console.WriteLine("[0] Go Back             : ");
                    System.Console.WriteLine("[7] Skill name          : " + details.Skill_name);
                    System.Console.WriteLine("[8]Skill Type           : " + details.Skill_Type);
                    System.Console.WriteLine("[9]Skill Level          : " + details.Skill_Level);
                }
                if (name == "3")
                {
                    System.Console.WriteLine("[0] Go Back             : ");
                    System.Console.WriteLine("[10]Company_name        : " + details.Company_name);
                    System.Console.WriteLine("[11] Company_Type       : " + details.Company_type);
                    System.Console.WriteLine("[12] Experience         : " + details.Experience);
                    System.Console.WriteLine("[13]Company_Desc        : " + details.Company_Description);
                }
                if (name == "4")
                {
                    System.Console.WriteLine("[0] Go Back             : ");
                    System.Console.WriteLine("[14]Highest Qualification : " + details.Highest_Graduation);
                    System.Console.WriteLine("[15] Institute            : " + details.Institute);
                    System.Console.WriteLine("[16] Department           : " + details.Department);
                    System.Console.WriteLine("[17] Start Year           : " + details.Start_year);
                    System.Console.WriteLine("[18] End Year             : " + details.End_year);
                }
                Console.WriteLine("/n---------------------------------------------------------/n");
                Console.Write("Please Enter Your Choice To Update: ");
                string userchoice = System.Console.ReadLine();

                switch (userchoice)
                {
                    case "0":
                        return "ShowDetails";
                    case "1":
                        System.Console.Write("Enter your Password to update: ");
                        string pattern1 = @"^.* (?=.{ 8,})(?=.*\d)(?=.*[a - z])(?=.*[A - Z])(?=.*[!*@#$%^&+=]).*$";

                        string password = System.Console.ReadLine();

                        if (Regex.IsMatch(password, pattern1))
                        {
                            details.PASSWORD = password;
                            repo.UpdateTrainer("Trainer_Detailes", "Password", details.PASSWORD, details.user_id);
                        }




                }

            }
}

