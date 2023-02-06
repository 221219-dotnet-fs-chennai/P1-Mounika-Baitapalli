using DataFluentApi.Entities;
using Models;

namespace DataFluentApi
{
    public class EFRepo : ISqlRepo<Entities.TrainerDetail>
    {
        FindTrainerDatabaseContext context =new FindTrainerDatabaseContext();
        private FindTrainerDatabaseContext _context;

        public EFRepo(FindTrainerDatabaseContext context) {
            _context = context;
        }

        public Entities.TrainerDetail AddTrainerDetail(Entities.TrainerDetail td )
        {
            _context.TrainerDetails.Add(td);
            _context.SaveChanges();
            return td;
        }

        /*public TrainerDetail Get(string EmailId)
        {
            return context.TrainerDetail;

        }*/

        /*public IEnumerable<TrainerDetail> GetGetAllTrainerDetail()
        {
            throw new NotImplementedException();
        }
*/
       /* public List<TrainerDetail> GetTrainersList()
        {
           return context.TrainerDetails.ToList();
        }*/

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









    