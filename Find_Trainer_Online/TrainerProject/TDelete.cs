using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Trainer_Data;

namespace TrainerProject
{
    internal class TDelete : TSignUp, IMenu
    {
        static string conStr = File.ReadAllText("../../../connectionstring.txt");
        SqlRepo repo = new SqlRepo(conStr);

        internal static Details details = new Details();
        public TDelete()
        {

        }
        public TDelete(Details d)
        {
            details = d;
        }


        public void Display()
        {
            System.Console.WriteLine("Welcome to Delete Page");
            System.Console.WriteLine("Please Choose one option to delete the data");
            System.Console.WriteLine("[M] To go Back");
            System.Console.WriteLine("[1] To Delete Trainer Details");
            System.Console.WriteLine("[2] To Delete Education Details");
            System.Console.WriteLine("[3] To Delete Skill_Set ");
            System.Console.WriteLine("[4] To Delete Company Details");

        }
        public new string UserChoice()
        {

            System.Console.Write("\nEnter your choice: ");
            int obj1 = Convert.ToInt32(Console.ReadLine());
            if (obj1 == 0)
            {
                return "Viewdetails";
            }
            if (obj1 == 1)
            {
                Console.Clear();
                Console.WriteLine("Delete DETAILS ");
                Console.WriteLine("[M] To go Back");
                Console.WriteLine("[1] To delete Trainer_Details");
                Console.WriteLine("[2] To delete Skill_Set");
                Console.WriteLine("[3] To delete Company_Details");
                Console.WriteLine("[4] To delete Education_Details");

                string choice = Console.ReadLine();
                if (choice == "0")
                {
                    Console.Clear();
                    return "TUpdate";
                }
                if (choice == "1")
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
                if (choice == "2")
                {
                    System.Console.WriteLine("[M] Go Back             : ");
                    System.Console.WriteLine("[9] Skill_1             : " + details.Skill_1);
                    System.Console.WriteLine("[10]Skill_2              : " + details.Skill_2);
                    System.Console.WriteLine("[11]Skill_3             : " + details.Skill_3);
                }
                if (choice == "3")
                {
                    System.Console.WriteLine("[0] Go Back               : ");
                    System.Console.WriteLine("[12]Company_Name          : " + details.Company_Name);
                    System.Console.WriteLine("[13] Experience_In_Years  : " + details.Experience_In_Years);
                    System.Console.WriteLine("[14]Position              : " + details.Position);


                }
                if (choice == "4")
                {
                    System.Console.WriteLine("[M] Go Back              : ");
                    System.Console.WriteLine("[15]Institution          : " + details.Institution);
                    System.Console.WriteLine("[16] Degree              : " + details.Degree);
                    System.Console.WriteLine("[17] Specialization      : " + details.Specialization);
                    System.Console.WriteLine("[18] Year_Of_Passing     : " + details.Year_Of_Passing);

                }
                Console.Write("Please Enter Your Choice To Delete: ");
                string comm = System.Console.ReadLine();

                switch (comm)
                {


                    case "0":
                        return "TUpdate";
                    case "1":
                        System.Console.WriteLine(".......Deleting Name......");
                        details.Name = "NULL";

                        repo.TDelete("Name", "Trainer_Details", details.User_Id);
                        return "TUpdate";
                    case "2":
                        System.Console.WriteLine(".......Deleting Age.......");
                        details.Age = 0;
                        repo.TDelete("Age", "Trainer_Details", details.User_Id);
                        return "TUpdate";
                    case "3":
                        System.Console.WriteLine(".......Deleting Gender.......");
                        details.Gender = "NULL";
                        repo.TDelete("Gender", "Trainer_Details", details.User_Id);
                        return "TUpdate";

                    case "4":
                        System.Console.WriteLine(".......Deleting EmailId.......");
                        details.EmailId = "NULL";
                        repo.TDelete("EmailId", "Trainer_Details", details.User_Id);
                        return "TUpdate";

                    case "5":
                        System.Console.WriteLine(".......Deleting Password.......");
                        details.Password = "NULL";
                        repo.TDelete("Password", "Trainer_Details", details.User_Id);
                        return "TUpdate";

                    case "6":
                        System.Console.WriteLine(".......Deleting Contact_Number......");
                        details.Contact_Number = "NULL";
                        repo.TDelete("Contact_Number", "Trainer_Details", details.User_Id);
                        return "TUpdate";
                    case "7":
                        System.Console.WriteLine(".......Deleting Location......");
                        details.Location = "NULL";
                        repo.TDelete("Location", "Trainer_Details", details.User_Id);
                        return "TUpdate";
                    case "8":
                        System.Console.WriteLine(".......Deleting SocialMedia_Profile......");
                        details.SocialMedia_Profile = "NULL";
                        repo.TDelete("SocialMedia_Profile", "Trainer_Details", details.User_Id);
                        return "TUpdate";

                    case "9":
                        System.Console.WriteLine(".......Deleting Skill_1.......");
                        details.Skill_1 = "NULL";
                        repo.TDelete("Skill_1", "Skill_Set", details.User_Id);
                        return "TUpdate";
                    case "10":
                        System.Console.WriteLine(".......Deleting Skill_2.......");
                        details.Skill_2 = "NULL";
                        repo.TDelete("Skill_2", "Skill_Set", details.User_Id);
                        return "TUpdate";
                    case "11":
                        System.Console.WriteLine(".......Deleting SkilL_3.......");
                        details.Skill_3 = "NULL";
                        repo.TDelete("Skill_3", "Skill_Set", details.User_Id);
                        return "TUpdate";


                    case "12":
                        System.Console.WriteLine(".......Deleting institution.......");
                        details.Institution = "NULL";
                        repo.TDelete("Institution", "Education_Details", details.User_Id);
                        return "TUpdate";

                    case "13":
                        System.Console.WriteLine(".......Deleting Degree.......");
                        details.Degree = "NULL";
                        repo.TDelete("Degree", "Education_Details", details.User_Id);
                        return "TUpdate";

                    case "14":
                        System.Console.WriteLine(".......Deleting Specialization......");
                        details.Specialization = "NULL";
                        repo.TDelete("Specialization", "Education_Details", details.User_Id);
                        return "TUpdate";
                    case "15":
                        System.Console.WriteLine(".......Deleting Year_Of_Passing.......");
                        details.Year_Of_Passing = "NULL";
                        repo.TDelete("Year_Of_Passing", "Education_Details", details.User_Id);
                        return "TUpdate";



                    case "16":
                        System.Console.WriteLine(".......Deleting Company Name......");
                        details.Company_Name = "NULL";
                        repo.TDelete("Company_Name", "Company_Details", details.User_Id);
                        return "Update";
                    case "17":
                        System.Console.WriteLine(".......Deleting Experience_in_Years......");
                        details.Experience_In_Years = "NULL";
                        repo.TDelete("Experience_In_Years", "Company_Details", details.User_Id);
                        return "TUpdate";
                    case "18":
                        System.Console.WriteLine(".......Deleting Position......");
                        details.Position = "NULL";
                        repo.TDelete("Position", "Company_Details", details.User_Id);
                        return "TUpdate";


                    default:

                        System.Console.WriteLine("Wrong choice, Try again!");
                        System.Console.WriteLine("Enter to continue");
                        System.Console.ReadLine();
                        return "TUpdate";

                }


               
            }
            return "Tlogin";
        }


    }

}
