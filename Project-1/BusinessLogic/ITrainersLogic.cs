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
        /*Company_Detail AddCompanyDetail(Company_Detail td);
         Education_Detail AddEducationDetail(Education_Detail td);
         Skill_Set AddSkillSet(Skill_Set ss);
 */

        IEnumerable<Trainer_Detail> GetAllTrainers();
        IEnumerable<Company_Detail> GetCompany_Details();
         IEnumerable<Skill_Set>GetSkill_Sets();
         IEnumerable<Education_Detail> GetEducation_Details();




        Trainer_Detail RemoveTrainerDetailByName(string td);
        /*Company_Detail RemoveCompanyDetailByUserId(int cd);
        Skill_Set RemoveSkillSetByUserId(int ss);
        Education_Detail RemoveEducationDetailByUserId(int ed);*/

        Trainer_Detail UpdateTrainerDetail(string Name,Trainer_Detail td);
        /*Education_Detail   UpdateEducationDetail(int UserId, Education_Detail education);
        Skill_Set UpdateSkillSet(Skill_Set ss);
        Company_Detail  UpdateCompanyDetail(Company_Detail td);
*/
       // Trainer_Detail GetTrainerDetailsByUser_Id(int id);

    }
}
