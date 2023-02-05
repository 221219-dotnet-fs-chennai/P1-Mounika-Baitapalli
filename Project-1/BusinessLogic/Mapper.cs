using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Trainer_Data = DataFluentApi.Entities;
using System.Net.Cache;
using Azure;
using System.Reflection;
using Microsoft.Exchange.WebServices.Data;

namespace BusinessLogic
{
    internal class Mapper
    {

        public static Models.Trainer TMap(Trainer_Data.TrainerDetail t)
        {
            return new Models.Trainer()
            {
                User_Id = t.UserId,
                Name = t.Name,
                Age = Convert.ToInt32(t.Age),
                Gender = t.Gender,
                EmailId = t.EmailId,
                Password = t.Password,
                Contact_Number = t.ContactNumber,
                Location = t.Location,
                SocialMedia_Profile = t.SocialMediaProfile,

            };
        }
        public static Trainer_Data.TrainerDetail TMap(Models.Trainer td)
        {
            return new Trainer_Data.TrainerDetail
            {
                UserId = td.User_Id,
                Name = td.Name,
                Age = Convert.ToInt32(td.Age),
                Gender = td.Gender,
                EmailId = td.EmailId,
                Password = td.Password,
                ContactNumber = td.Contact_Number,
                Location = td.Location,
                SocialMediaProfile = td.SocialMedia_Profile,
            };
        }

        public static IEnumerable<Models.Trainer>trMap(Trainer_Data.TrainerDetail td)
        {
            return td.Select(trMap);
        }
        public static Models.Trainer EdMap(Trainer_Data.EducationDetail ed)
        {
            return new Models.Trainer()
            {
                User_Id = ed.UserId,
                Institution = ed.Institution,
                Degree = ed.Degree,
                Specialization = ed.Specialization,
                Year_Of_Passing = ed.YearOfPassing,


            };

        }
        public static Trainer_Data.EducationDetail EdMap(Models.Trainer e)
        {
            return new Trainer_Data.EducationDetail
            {
                UserId = e.User_Id,
                Institution = e.Institution,
                Degree = e.Degree,
                Specialization = e.Specialization,
                YearOfPassing = e.Year_Of_Passing,
            };
        }
        public static IEnumerable<Models.Trainer> edMap(Trainer_Data.EducationDetail edu)
        {
            return edu.Select(edMap);
        }

        public static Models.Trainer CmpMap(Trainer_Data.CompanyDetail cmp)
        {
            return new Models.Trainer()
            {
                User_Id = cmp.UserId,
                Company_Name = cmp.CompanyName,
                Experience_In_Years = cmp.ExperienceInYears,
                Position = cmp.Position,

            };
        }
        public static Trainer_Data.CompanyDetail CmpMap(Models.Trainer c)
        {
            return new Trainer_Data.CompanyDetail
            {
                UserId = c.User_Id,
                CompanyName = c.Company_Name,
                ExperienceInYears = c.Experience_In_Years,
                Position = c.Position,
            };
        }
        public static IEnumerable<Models.Trainer> cmMap(Trainer_Data.CompanyDetail compn)
        {
            return compn.Select(cmMap);
        }

        public static Models.Trainer SkillMap(Trainer_Data.SkillSet sk)
        {
            return new Models.Trainer()
            {
                User_Id = sk.UserId,
                Skill_1 = sk.Skill1,
                Skill_2 = sk.Skill2,
                Skill_3 = sk.Skill3,
            };
        }

        public static Trainer_Data.SkillSet SkillMap(Models.Trainer ss)
        {
            return new Trainer_Data.SkillSet
            {
                UserId = ss.User_Id,
                Skill1 = ss.Skill_1,
                Skill2 = ss.Skill_2,
                Skill3 = ss.Skill_3,
            };
        }
        public static IEnumerable<Models.Trainer>sMap(Trainer_Data.SkillSet skill)
        {
            return skill.Select(sMap);
        }



    }
}






     
       

                 



    






    












            
         







         
    

