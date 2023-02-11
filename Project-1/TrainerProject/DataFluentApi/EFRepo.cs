using DataFluentApi.Entities;
using Models;

namespace DataFluentApi
{
    public class EFRepo : ISqlRepo
    {
        //FindTrainerDatabaseContext context = new FindTrainerDatabaseContext();
        private FindTrainerDatabaseContext _context;

        public EFRepo(FindTrainerDatabaseContext context)
        {
            _context = context;
        }

        public TrainerDetail AddTrainerDetail(TrainerDetail t)
        {
            _context.TrainerDetails.Add(t);
            _context.SaveChanges();
            return t;
        }

        public List<Entities.TrainerDetail> GetAllTrainers()
        {
            return _context.TrainerDetails.ToList();
        }
        public List<Entities.CompanyDetail> GetCompany_Details()
        {
            return _context.CompanyDetails.ToList();
        }
        public List<Entities.EducationDetail> GetEducation_Details()
        {
            return _context.EducationDetails.ToList();
        }
        public List<Entities.SkillSet> GetSkill_Sets()
        {
            return _context.SkillSets.ToList();
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










    