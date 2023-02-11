using DataFluentApi;
using DataFluentApi.Entities;
using Models;


namespace BusinessLogic
{
    public class TrainersLogic : ITrainersLogic
    {
        ISqlRepo _repo;

        public TrainersLogic(ISqlRepo repo)
        {

            _repo = repo;
        }
  
       public Trainer_Detail AddTrainerDetail(Trainer_Detail trainer_detail) 
        {

            return Mapper.TMap(_repo.AddTrainerDetail(Mapper.TMap(trainer_detail)));
        }
        /*public Education_Detail AddEducationDetail(Education_Detail edu)
        {
            return Mapper.EdMap(_repo.AddEducationDetail(Mapper.EdMap(edu)));
        }
        public Company_Detail AddCompanyDetail(Company_Detail compn)
        {
            return Mapper.CmpMap(_repo.AddCompanyDetail(Mapper.CmpMap(compn)));

        }
        public Skill_Set AddSkillSet(Skill_Set s)
        {
            return Mapper.SkillMap(_repo.AddSkillSet(Mapper.SkillMap(s)));
        }*/

        public IEnumerable<Trainer_Detail> GetAllTrainers()
        {
            return Mapper.TMap(_repo.GetAllTrainers());
        }
        public IEnumerable<Education_Detail> GetEducation_Details()
        {
            return Mapper.EdMap(_repo.GetEducation_Details());
        }
        public IEnumerable<Skill_Set> GetSkill_Sets()
        {
            return Mapper.SkillMap(_repo.GetSkill_Sets());
        }
        public IEnumerable<Company_Detail> GetCompany_Details()
        {
            return Mapper.CmpMap(_repo.GetCompany_Details());
        }


        /* public Trainer_Detail GetTrainerDetailsByUser_Id(int id)
         {
             var search = _repo.GetTrainer_Details().Where(td => td.UserId == id).FirstOrDefault();
             return Mapper.TMap(search);
         }*/
        public Trainer_Detail RemoveTrainerDetailByName(string td)
        {
            var deleteTrainerDetail = _repo.RemoveTrainerDetail(td);
            if (deleteTrainerDetail != null)
                return Mapper.TMap(deleteTrainerDetail);
            else
                return null;

        }
         public Trainer_Detail UpdateTrainerDetail (string Name,Trainer_Detail td)
        {
            var trainer = (from tds in _repo.GetAllTrainers() where tds.Name == Name && tds.UserId == td.User_Id select tds).FirstOrDefault();

            if (trainer != null)
            {
                
                trainer.UserId = td.User_Id;
                trainer.Name = td.Name;
                trainer.Age = td.Age;
                trainer.Gender = td.Gender;
                trainer.EmailId = td.EmailId;
                trainer.Password = td.Password;
                trainer.ContactNumber = td.Contact_Number;
                trainer.Location = td.Location;
                trainer.SocialMediaProfile = td.SocialMedia_Profile;


                trainer = _repo.UpdateTrainerDetail(trainer);
            }
            return Mapper.TMap(trainer);
        }

       
    }
       
}
