using DataFluentApi.Entities;
using Models;


namespace BusinessLogic
{
    public class TrainersLogic : ITrainersLogic
    {
        ISqlRepo<DataFluentApi.Entities.TrainerDetail> _repo;

        public TrainersLogic(ISqlRepo<DataFluentApi.Entities.TrainerDetail> repo)
        {

            _repo = repo;
        }
        public Trainer_Detail AddTrainerDetail(Trainer_Detail td)
        {
            return Mapper.TMap(_repo.AddTrainerDetail(Mapper.TMap(td)));
        }

        public IEnumerable<Trainer_Detail> GetTrainer_Details()
        {
            return Mapper.TMap(_repo.GetTrainer_Details());
        }

        /*public IEnumerable<Trainer_Detail> GetTrainer_Details()
        {
            return Mapper.TMap(_repo.GetTrainerDetails());
        }*/

        public Trainer_Detail GetTrainerDetailsByUser_Id(int id)
        {
            var search = _repo.GetTrainer_Details().Where(td => td.UserId == id).FirstOrDefault();
            return Mapper.TMap(search);
        }
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
            var trainer = (from tds in _repo.GetTrainer_Details() where tds.Name == Name && tds.UserId == td.User_Id select tds).FirstOrDefault();

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
