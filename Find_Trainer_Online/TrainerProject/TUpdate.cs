using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Trainer_Data;

namespace TrainerProject
{
    internal class TUpdate : TSignUp, IMenu
    {
        static string conStr = File.ReadAllText("../../../connectionstring.txt");
        SqlRepo repo = new SqlRepo(conStr);
        public TUpdate() {
        }
        Details details = new Details();
        public TUpdate(Details d)

            {
                details = d;
            }
            public void Display()
        {
            System.Console.Clear();
            Console.WriteLine("[0] for to show profile data");
            Console.WriteLine("[1] for to update details");
            Console.WriteLine("[2] for to delete details");
            Console.WriteLine("[5] To for logout");

        }
        public new string UserChoice()
        {
            
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
                Console.WriteLine("[M] To go Back");
                Console.WriteLine("[1] To Update Trainer_Details");
                Console.WriteLine("[2] To Update Skill_Set");
                Console.WriteLine("[3] To Update Company_Details");
                Console.WriteLine("[4] To Update Education_Details");

                string match = Console.ReadLine();
                if (match == "0")
                {
                    Console.Clear();
                    return "TUpdate";
                }
                if (match == "1")
                {
                    System.Console.WriteLine("[M] Go Back             : ");

                    System.Console.WriteLine("[1] Name                : " + details.Name);
                    System.Console.WriteLine("[2] Age                 : " + details.Age);
                    System.Console.WriteLine("[3] Gender              : " + details.Gender);
                    System.Console.WriteLine("[4] EmailId             : " + details.EmailId);
                    System.Console.WriteLine("[5] Password            : " + details.Password);
                    System.Console.WriteLine("[6] Contact Number      : " + details.Contact_Number);
                    System.Console.WriteLine("[7] Location            : " + details.Location);
                    System.Console.WriteLine("[8] SocialMedia_Profile : " + details.SocialMedia_Profile);
                }
                if (match == "2")
                {
                    System.Console.WriteLine("[M] Go Back             : ");
                    System.Console.WriteLine("[9] Skill_1             : " + details.Skill_1);
                    System.Console.WriteLine("[10]Skill_2              : " + details.Skill_2);
                    System.Console.WriteLine("[11]Skill_3             : " + details.Skill_3);
                }
                if (match == "3")
                {
                    System.Console.WriteLine("[0] Go Back               : ");
                    System.Console.WriteLine("[12]Company_Name          : " + details.Company_Name);
                    System.Console.WriteLine("[13] Experience_In_Years  : " + details.Experience_In_Years);
                    System.Console.WriteLine("[14]Position              : " + details.Position);


                }
                if (match == "4")
                {
                    System.Console.WriteLine("[M] Go Back              : ");
                    System.Console.WriteLine("[15]Institution          : " + details.Institution);
                    System.Console.WriteLine("[16] Degree              : " + details.Degree);
                    System.Console.WriteLine("[17] Specialization      : " + details.Specialization);
                    System.Console.WriteLine("[18] Year_Of_Passing     : " + details.Year_Of_Passing);

                }

                Console.Write("Please Enter Your Choice To Update: ");
                string myobj = System.Console.ReadLine();

                switch (myobj)
                {
                    case "0":
                        return "ShowDetails";

                    case "1":
                        System.Console.Write("Enter your Name to Update : ");
                        details.Name = System.Console.ReadLine();
                        repo.TUpdate("Trainer_Details", "Name", details.Name, details.User_Id);
                        return "TUpdate";
                    case "2":
                        try
                        {
                            System.Console.Write("Enter your Age to update: ");
                            details.Age = Convert.ToInt32(System.Console.ReadLine());
                            repo.TUpdate("Trainer_Details", "Age", Convert.ToString(details.Age), details.User_Id);
                        }
                        catch (Exception ex)
                        {
                            System.Console.WriteLine("Age should be in numbers!!");
                            System.Console.WriteLine(ex.Message);
                            System.Console.ReadLine();
                        }
                        return "TUpdate";
                    case "3":
                        System.Console.Write("Enter your Gender: ");
                        details.Gender = System.Console.ReadLine();
                        repo.TUpdate("Trainer_Details", "Gender", details.Gender, details.User_Id);
                        return "TUpdate";
                    case "4":
                        System.Console.Write("enter your EmailId:");
                        details.EmailId = System.Console.ReadLine();
                        repo.TUpdate("Trainer_Details", "EmailId", details.EmailId, details.User_Id);
                        return "TUpdate";

                    case "5":
                        System.Console.Write("Enter your Password to update: ");
                        string pattern1 = @"^.* (?=.{ 8,})(?=.*\d)(?=.*[a - z])(?=.*[A - Z])(?=.*[!*@#$%^&+=]).*$";

                        string Password = System.Console.ReadLine();

                        if (Regex.IsMatch(Password, pattern1))
                        {
                            details.Password = Password;
                            repo.TUpdate("Trainer_Details", "Password", details.Password, details.User_Id);
                        }
                        else
                        {
                            System.Console.WriteLine("Wrong pattern try again...");
                            System.Console.ReadLine();
                        }
                        return "TUpdate";

                    case "6":
                        System.Console.Write("Enter your Mobile number to update: ");
                        string pattern = @"\(?\d{3}\)?(-|.|\s)?\d{3}(-|.)?\d{4}";

                        string Contact_Number = System.Console.ReadLine();

                        if (Regex.IsMatch(Contact_Number, pattern))
                        {
                            details.Contact_Number = Contact_Number;
                            repo.TUpdate("Trainer_Details", "Contact_Number", details.Contact_Number, details.User_Id);
                        }
                        else
                        {
                            System.Console.WriteLine("Wrong pattern try again...");
                            System.Console.ReadLine();
                        }
                        return "TUpdate";

                    case "7":
                        System.Console.Write("Enter you Location to update: ");
                        details.Location = System.Console.ReadLine();
                        repo.TUpdate("Trainer_Details", "Location", details.Location, details.User_Id);
                        return "TUpdate";

                    case "8":
                        System.Console.Write("Enter you SocialMedia_Profile to update: ");
                        details.SocialMedia_Profile = System.Console.ReadLine();
                        repo.TUpdate("Trainer_Details", "SocialMedia_Profile", details.SocialMedia_Profile, details.User_Id);
                        return "TUpdate";
                    case "9":
                        System.Console.Write("Enter your Skill_1 name to update: ");
                        details.Skill_1 = System.Console.ReadLine();
                        repo.TUpdate("Skill_Set", "Skill_1", details.Skill_1, details.User_Id);
                        return "TUpdate";
                    case "10":
                        System.Console.Write("Enter your Skill_2 name to update: ");
                        details.Skill_2 = System.Console.ReadLine();
                        repo.TUpdate("Skill_Set", "Skill_2", details.Skill_2, details.User_Id);
                        return "TUpdate";
                    case "11":
                        System.Console.Write("Enter your Skill_3 name to update: ");
                        details.Skill_3 = System.Console.ReadLine();

                        repo.TUpdate("Skill_Set", "Skill_3", details.Skill_3, details.User_Id);
                        return "TUpdate";
                    case "12":
                        System.Console.Write("Enter your Company_Name to update: ");
                        details.Company_Name = System.Console.ReadLine();
                        repo.TUpdate("Company_Details", "Company_Name", details.Company_Name, details.User_Id);
                        return "TUpdate";
                    case "13":
                        System.Console.Write("Enter your Experience_In_Years: ");
                        details.Experience_In_Years = System.Console.ReadLine();
                        repo.TUpdate("Company_Details", "Experience_In_Years", details.Experience_In_Years, details.User_Id);
                        return "TUpdate";
                    case "14":
                        System.Console.Write("Enter your Position: ");
                        details.Position = System.Console.ReadLine();
                        repo.TUpdate("Company_Details", "Position", details.Position, details.User_Id);
                        return "TUpdate";
                    case "15":
                        System.Console.Write("Enter your Institution: ");
                        details.Institution = System.Console.ReadLine();
                        repo.TUpdate("Education_Details", "Institution", details.Institution, details.User_Id);
                        return "TUpdate";
                    case "16":
                        System.Console.Write("Enter your Degree: ");
                        details.Degree = System.Console.ReadLine();
                        repo.TUpdate("Education_Details", "Degree", details.Degree, details.User_Id);
                        return "TUpdate";

                    case "17":
                        System.Console.Write("Enter your Specialization: ");
                        details.Specialization = System.Console.ReadLine();
                        repo.TUpdate("Education_Details", "Specialization", details.Specialization, details.User_Id);
                        return "TUpdate";
                    case "18":
                        System.Console.Write("Enter your Year_Of_Passing: ");
                        details.Year_Of_Passing = System.Console.ReadLine();
                        repo.TUpdate("Education_Details", "Year_Of_Passing", details.Year_Of_Passing, details.User_Id);
                        return "TUpdate";

                }




                Console.WriteLine("Logging Out......Click Enter to Continue");
                Console.ReadLine();
                return "Menu";


               
            }
            return "ShowDetails";
        }

    }
}

