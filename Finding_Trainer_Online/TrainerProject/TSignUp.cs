using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using Trainer_Data;

namespace TrainerProject
{
    internal class TSignUp : IMenu
    {
        internal static Details details = new Details();

        static string conStr = "C:\\P1-Mounika-Baitapalli\\Finding_Trainer_Online\\TrainerProject\\connectionstring.txt";
        SqlRepo repo = new SqlRepo(conStr);
        public TSignUp(Details d)
        {
            details = d;
        }
        public TSignUp()
        {

        }


        public void Display()
        {
            System.Console.WriteLine("\n-------Entering Trainers Details-------\n");
            System.Console.WriteLine("[M] Menu");
            System.Console.WriteLine("[1] Save");
            System.Console.WriteLine("[2] Name                     : " + details.Name);
            System.Console.WriteLine("[3] Age                      : " + details.Age);
            System.Console.WriteLine("[4] Gender                   : " + details.Gender);
            System.Console.WriteLine("[5] EmailId                  : " + details.EmailId);
            System.Console.WriteLine("[6] Password                 : " + details.Password);
            System.Console.WriteLine("[7] Contact_Number           : " + details.Contact_Number);
            System.Console.WriteLine("[8] Location                 : " + details.Location);
            System.Console.WriteLine("[9] Website                  : " + details.Website);
            System.Console.WriteLine("[10]Skill_1                  : " + details.Skill_1);
            System.Console.WriteLine("[11]Skill_2                  : " + details.Skill_2);
            System.Console.WriteLine("[12]Skill_3                  : " + details.Skill_3);
            System.Console.WriteLine("[13] Company_Name            : " + details.Company_Name);
            System.Console.WriteLine("[14] Experience_In_Years     : " + details.Experience_In_Years);
            System.Console.WriteLine("[15]Position                 : " + details.Position);
            System.Console.WriteLine("[16]Institution              : " + details.Institution);
            System.Console.WriteLine("[17] Degree                  : " + details.Degree);
            System.Console.WriteLine("[18]Specialization           : " + details.Specialization);
            System.Console.WriteLine("[19] Year_Of_Passing         : " + details.Year_Of_Passing);

        }
        public string UserChoice()
        {
            System.Console.WriteLine("--------------------------");
            System.Console.Write("\nEnter your choice: ");
            string userchoice = System.Console.ReadLine();

            switch (userchoice)
            {
                case "M":
                    return "Menu";
                /*case "1":
                    try
                    {
                        Console.WriteLine("Adding trainer details");
                        repo.Add(details);
                        details = new Details();
                        System.Console.WriteLine("Successfully added");
                        Console.WriteLine("trainer details added Successfully ");

                    
                    }
                    catch (System.Exception ex)
                    {
                        Console.WriteLine($"failed to add trainer details {ex.Message}");
                        System.Console.WriteLine("Press enter to continue");
                        System.Console.ReadLine();
                       
                    }
                    return "TSignUp";*/
                case "1":
                    Console.WriteLine("Adding trainer details");
                    repo.Add(details);
                    details = new Details();
                    System.Console.WriteLine("Successfully added");
                    Console.WriteLine("trainer details added Successfully ");
                    System.Console.WriteLine("Press enter to continue");
                    System.Console.ReadLine();
                    return "TSignUp";
                case "2":
                    System.Console.Write("Enter your Name: ");
                    details.Name = System.Console.ReadLine();
                    return "TSignUp";
                case "3":
                    try
                    {
                        System.Console.Write("Enter your Age: ");
                        details.Age = Convert.ToInt32(System.Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        System.Console.WriteLine("Age should be in numbers!!");
                        System.Console.WriteLine(ex.Message);
                        System.Console.ReadLine();
                    }
                    return "TSignUp";
                case "4":
                    System.Console.Write("Enter your Gender: ");
                    details.Gender = System.Console.ReadLine();
                    return "TSignUp";
                case "5":
                    System.Console.Write("Enter your Email ID: ");
                    string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

                    string Email = System.Console.ReadLine();

                    if (Regex.IsMatch(Email, pattern))
                    {
                        details.EmailId = Email;
                    }
                    else
                    {
                        System.Console.WriteLine("You have entered a Wrong pattern, try again...");
                        System.Console.ReadLine();
                    }
                    return "TSignUp";
                
                case "6":
                    System.Console.WriteLine("At least one lower case letter,\r\nAt least one upper case letter,\r\nAt least 4 character,\r\nAt least one number\r\nAt most 8 characters length");
                    System.Console.Write("Enter your Password: ");
                    string pattern1 = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$";

                    string password = System.Console.ReadLine();

                    if (Regex.IsMatch(password, pattern1))
                    {
                        details.Password = password;
                    }
                    else
                    {
                        System.Console.WriteLine("You have entered a Wrong pattern,try again...");
                        System.Console.ReadLine();
                    }
                    return "TSignUp";
                
                

                case "7":
                    System.Console.Write("Enter your Contact_Number: ");
                    string pattern2 = @"\(?\d{3}\)?(-|.|\s)?\d{3}(-|.)?\d{4}";

                    string Contact_Number = System.Console.ReadLine();

                    if (Regex.IsMatch(Contact_Number, pattern2))
                    {
                        details.Contact_Number = Contact_Number;
                    }
                    else
                    {
                        System.Console.WriteLine("You have entered a Wrong pattern,try again...");
                        System.Console.ReadLine();
                    }
                    return "TSignUp";
                case "8":
                    System.Console.WriteLine("Enter your Location");
                    details.Location = System.Console.ReadLine();
                    return "TSignUp";

                case "9":
                    System.Console.Write("Enter you Website: ");
                    details.Website = System.Console.ReadLine();
                    return "TSignUp";

                case "10":
                    System.Console.Write("Enter your Skill_1: ");
                    details.Skill_1 = System.Console.ReadLine();
                    return "TSignUp";

                case "11":
                    System.Console.Write("Enter your Skill_2: ");
                    details.Skill_2 = System.Console.ReadLine();
                    return "TSignUp";

                case "12":
                    System.Console.Write("Enter your Skill_3: ");
                    details.Skill_3 = System.Console.ReadLine();
                    return "TSignUp";
                case "13":
                    System.Console.Write("Enter your Company_Name: ");
                    details.Company_Name = System.Console.ReadLine();
                    return "TSignUp";
                case "14":
                    System.Console.Write("Enter your Experience_In_Years: ");
                    details.Experience_In_Years = System.Console.ReadLine();
                    return "TSignUp";
                case "15":
                    System.Console.Write("Enter your Position: ");
                    details.Position = System.Console.ReadLine();
                    return "TSignUp";
                
                case "16":
                    System.Console.Write("Enter your Institution: ");
                    details.Institution = System.Console.ReadLine();
                    return "TSignUp";
                case "17":
                    System.Console.Write("Enter your Degree: ");
                    details.Degree = System.Console.ReadLine();
                    return "TSignUp";
                case "18":
                    System.Console.Write("Enter your Specialization: ");
                    details.Specialization = System.Console.ReadLine();
                    return "TSignUp";
                case "19":
                    System.Console.Write("Enter your Year_Of_Passing: ");
                    details.Year_Of_Passing = System.Console.ReadLine();
                    return "TSignUp";
            
                default:
                    System.Console.WriteLine("------------------------------");
                    System.Console.WriteLine("Wrong choice, Try again!");
                    System.Console.WriteLine("Enter to continue");
                    System.Console.ReadLine();
                    return "TSignUp";

            }
        }
    }
}












































