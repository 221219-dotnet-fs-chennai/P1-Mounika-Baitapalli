using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFluentApi;
using DataFluentApi.Entities;

namespace DataFluentApi
{
    public interface ISqlRepo
    {
        //IEnumerable<DataFluentApi.Entities.TrainerDetail> GetGetAllTrainerDetail();

        
        DataFluentApi.Entities.TrainerDetail AddTrainerDetail(Entities.TrainerDetail trainer_detail);
        DataFluentApi.Entities.EducationDetail AddEducationDetail(Entities.EducationDetail edu);
        DataFluentApi.Entities.CompanyDetail AddCompanyDetail(Entities.CompanyDetail cmpn);
        DataFluentApi.Entities.SkillSet AddSkillSet(Entities.SkillSet ss);

       // List<Entities.TrainerDetail> GetAllDetails();

        List<Entities.TrainerDetail> GetAllTrainers();
        List<Entities.CompanyDetail> GetCompany_Details();
        List<Entities.EducationDetail> GetEducation_Details();
        List<Entities.SkillSet> GetSkill_Sets();

        

        /*Entities.TrainerDetail RemoveTrainerDetailByName(string Name);
        Entities.CompanyDetail DeleteCompanyDetail( int User_Id);
        Entities.EducationDetail DeleteEducationDetail(int User_Id);
        Entities.SkillSet DeleteSkillSet(int User_Id);
          */

       Entities.TrainerDetail DeleteTrainerDetail(string EmailId);

        Entities.TrainerDetail UpdateTrainerDetail(Entities.TrainerDetail td);
        Entities.CompanyDetail UpdateCompanyDetail(Entities.CompanyDetail cmp);
        Entities.SkillSet UpdateSkillSet(Entities.SkillSet ss);
        Entities.EducationDetail UpdateEducationDetail(Entities.EducationDetail ed);


        bool Login(string EmailId,string Password);


    }
}
