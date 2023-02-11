using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFluentApi;

namespace DataFluentApi
{
    public interface ISqlRepo
    {
        //IEnumerable<DataFluentApi.Entities.TrainerDetail> GetGetAllTrainerDetail();
        

        DataFluentApi.Entities.TrainerDetail AddTrainerDetail(Entities.TrainerDetail trainer_detail);
      /*  EducationDetail AddEducatonDetail(EducationDetail edu);
        CompanyDetail AddCompanyDetail(CompanyDetail cmpn);
        SkillSet AddSkillSet(SkillSet ss);*/


        List<Entities.TrainerDetail> GetAllTrainers();
        List<Entities.CompanyDetail> GetCompany_Details();
        List<Entities.EducationDetail> GetEducation_Details();
        List<Entities.SkillSet> GetSkill_Sets();

        Entities.TrainerDetail RemoveTrainerDetail(string Name);

        Entities.TrainerDetail UpdateTrainerDetail(Entities.TrainerDetail td);




        /* bool Tlogin(string EmailId);
         void TUpdate(string tableName, string columnName, string newValue, int User_Id);

         //void DeleteTrainer(string col, string table, int User_Id);
         //void TDelete(string col, string table, int User_Id);

         void TDelete(string column, string table, int User_Id);*/
        //st<Trainer> GetTrainersList();
    }
}
