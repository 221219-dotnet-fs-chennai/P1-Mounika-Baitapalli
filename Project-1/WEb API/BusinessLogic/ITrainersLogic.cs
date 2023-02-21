using DataFluentApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace BusinessLogic
{
    public interface ITrainersLogic
    {
           

        // Trainer_Detail GetTrainerDetailsByUser_Id(int id);

        Trainer_Detail AddTrainerDetail(Trainer_Detail trainer_detail);
        Company_Detail AddCompanyDetail(Company_Detail td);
         Education_Detail AddEducationDetail(Education_Detail td);
         Skill_Set AddSkillSet(Skill_Set s);


 

        IEnumerable<Trainer_Detail> GetAllTrainers();
        IEnumerable<Company_Detail> GetCompany_Details();
         IEnumerable<Skill_Set>GetSkill_Sets();
         IEnumerable<Education_Detail> GetEducation_Details();

        //IEnumerable<Trainer_Detail>GetAllDetails();



        //Trainer_Detail RemoveTrainerDetailByName(string td);
        // Company_Detail DeleteCompanyDetail(int cd);
        // Skill_Set DeleteSkillSet(int ss);
        //Education_Detail DeleteEducationDetail(int ed);

        //Company_Detail DeleteCompanyDetail(Company_Detail cd);

        Trainer_Detail DeleteTrainerDetail(string EmailId);





        Trainer_Detail UpdateTrainerDetail(int User_Id, Trainer_Detail td);
        Education_Detail   UpdateEducationDetail(int User_Id, Education_Detail ed);
        Skill_Set UpdateSkillSet(int User_Id,Skill_Set ss);
        Company_Detail  UpdateCompanyDetail(int User_Id, Company_Detail td);


        bool Login(string EmailId, string Password);



    }
}
