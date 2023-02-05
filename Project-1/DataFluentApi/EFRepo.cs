using DataFluentApi.Entities;
using Models;

namespace DataFluentApi
{
    public class EFRepo : ISqlRepo<Entities.TrainerDetail>
    {
        FindTrainerDbContext context =new FindTrainerDbContext();

        public Entities.TrainerDetail Add(Entities.TrainerDetail details)
        {
            context.Add(details);
            context.SaveChanges();
            return details;
        }

        public TrainerDetail Get(string EmailId)
        {
            return context.TrainerDetail;

        }

        /*public IEnumerable<TrainerDetail> GetGetAllTrainerDetail()
        {
            throw new NotImplementedException();
        }
*/
        public List<TrainerDetail> GetTrainersList()
        {
           return context.TrainerDetails.ToList();
        }

       /* public void TDelete(string column, string table, int User_Id)
        {
            context.Delete(context.TrainerDetails);
        }

        public bool Tlogin(string EmailId)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(string tableName, string columnName, string newValue, int User_Id)
        {
            throw new NotImplementedException();
        }*/
    }
}









    