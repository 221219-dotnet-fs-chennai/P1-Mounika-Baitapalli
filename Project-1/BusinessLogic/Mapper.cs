using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DataFluentApi.Entities;
using System.Net.Cache;
using Azure;


namespace BusinessLogic
{
    public class Mapper
    {
        public static Models.Trainer_Detail TMap(DataFluentApi.Entities.TrainerDetail t)
        {
            return new Models.Trainer_Detail()
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
        public static DataFluentApi.Entities.TrainerDetail TMap(Models.Trainer_Detail td)
        {
            return new DataFluentApi.Entities.TrainerDetail()
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

        public static IEnumerable<Models.Trainer_Detail>TMap(IEnumerable<DataFluentApi.Entities.TrainerDetail> td )
        {
            return td.Select(TMap);
        }
        public static Models.Education_Detail EdMap(DataFluentApi.Entities.EducationDetail ed)
        {
            return new Models.Education_Detail()
            {
                User_Id = ed.UserId,
                Institution = ed.Institution,
                Degree = ed.Degree,
                Specialization = ed.Specialization,
                Year_Of_Passing = ed.YearOfPassing,


            };

        }
        public static DataFluentApi.Entities.EducationDetail EdMap(Models.Education_Detail e)
        {
            return new DataFluentApi.Entities.EducationDetail
            {
                UserId = e.User_Id,
                Institution = e.Institution,
                Degree = e.Degree,
                Specialization = e.Specialization,
                YearOfPassing = e.Year_Of_Passing,
            };
        }
        public static IEnumerable<Models.Education_Detail> EdMap(IEnumerable<DataFluentApi.Entities.EducationDetail> edu )
        {
            return edu.Select(EdMap);
        }

        public static Models.Company_Detail CmpMap(DataFluentApi.Entities.CompanyDetail cmp)
        {
            return new Models.Company_Detail()
            {
                User_Id = cmp.UserId,
                Company_Name = cmp.CompanyName,
                Experience_In_Years = cmp.ExperienceInYears,
                Position = cmp.Position,

            };
        }
        public static DataFluentApi.Entities.CompanyDetail CmpMap(Models.Company_Detail c)
        {
            return new DataFluentApi.Entities.CompanyDetail
            {
                UserId = c.User_Id,
                CompanyName = c.Company_Name,
                ExperienceInYears = c.Experience_In_Years,
                Position = c.Position,
            };
        }
        public static IEnumerable<Models.Company_Detail> CmpMap(IEnumerable<DataFluentApi.Entities.CompanyDetail> compn)
        {
            return compn.Select(CmpMap);
        }

        public static Models.Skill_Set SkillMap(DataFluentApi.Entities.SkillSet sk)
        {
            return new Models.Skill_Set()
            {
                User_Id = sk.UserId,
                Skill_1 = sk.Skill1,
                Skill_2 = sk.Skill2,
                Skill_3 = sk.Skill3,
            };
        }

        public static DataFluentApi.Entities.SkillSet SkillMap(Models.Skill_Set ss)
        {
            return new DataFluentApi.Entities.SkillSet
            {
                UserId = ss.User_Id,
                Skill1 = ss.Skill_1,
                Skill2 = ss.Skill_2,
                Skill3 = ss.Skill_3,
            };
        }
        public static IEnumerable<Models.Skill_Set>SkillMap(IEnumerable<DataFluentApi.Entities.SkillSet> skill)
        {
            return skill.Select(SkillMap);
        }


      
    }
}






     
       

                 



    






    












            
         







         
    

