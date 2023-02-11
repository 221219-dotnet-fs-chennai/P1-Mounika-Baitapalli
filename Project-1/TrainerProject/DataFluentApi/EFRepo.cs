using DataFluentApi.Entities;
using Models;

namespace DataFluentApi
{
    public class EFRepo : ISqlRepo<Entities.TrainerDetail>
    {
        FindTrainerDatabaseContext context = new FindTrainerDatabaseContext();
        private FindTrainerDatabaseContext _context;

        public EFRepo(FindTrainerDatabaseContext context)
        {
            _context = context;
        }

      
        public List<Entities.TrainerDetail> GetTrainer_Details()
        {
            return _context.TrainerDetails.ToList();
        }
        public Entities.TrainerDetail RemoveTrainerDetail(string Name)
        {
            var search = _context.TrainerDetails.Where(td => td.Name == Name).FirstOrDefault();
            if (search != null)
            {
                _context.TrainerDetails.Remove(search);
                _context.SaveChanges();
            }

            return search;
        }
        public Entities.TrainerDetail UpdateTrainerDetail(Entities.TrainerDetail trainer)
        {
            _context.TrainerDetails.Update(trainer);
            _context.SaveChanges();
            return trainer;

        }

    }

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










    