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
    }
       
}
