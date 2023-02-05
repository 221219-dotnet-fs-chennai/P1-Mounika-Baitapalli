using DataFluentApi.Entities;
using Models;
using datafirst= DataFluentApi.Entities;

namespace BusinessLogic
{
    public class TrainerDetailLogic : ITrainerDetailLogic
    {
        ISqlRepo<datafirst.TrainerDetail> _repo;

        public TrainerDetailLogic(ISqlRepo<datafirst.TrainerDetail> repo)
        {

            _repo = repo;
        }
        public TrainerDetail AddTrainerDetail(TrainerDetail trainerDetail)
        {
            return Mapper.TMap(_repo.AddTrainerDetail(Mapper.TMap(trainerDetail)));
        }
    }
       
}
