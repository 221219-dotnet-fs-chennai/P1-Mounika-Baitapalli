
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainer_Data;
using TrainerProject;

namespace TrainerProject
{
    public class GetTrainersList : IMenu
    {
        static string conStr = File.ReadAllText("../../../connectionstring.txt");
        ISqlRepo repo = new SqlRepo(conStr);
        public void Display()
        {
            Console.WriteLine("[G] TO get all trainers");
            Console.WriteLine("[0] To go Back");
        }

        public string UserChoice()
        {
            Console.WriteLine("Enter Your Choice:");
            string mychoice = Console.ReadLine();
            switch (mychoice)
            {
                case "0":
                    return "Signup";
                case "G":
                    var listof = repo.GetTrainersList();
                    foreach (var i in listof)
                    {
                        Console.WriteLine(i.details());
                    }
                    return "Menu";
            }
            return "Menu";
        }

    }
}