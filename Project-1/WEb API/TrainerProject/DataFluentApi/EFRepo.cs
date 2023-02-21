using DataFluentApi.Entities;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DataFluentApi
{
    public class EFRepo : ISqlRepo
    {
        //FindTrainerDatabaseContext context = new FindTrainerDatabaseContext();
        private FindTrainerDatabaseContext _context;
        private readonly object bb;

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
        public SkillSet AddSkillSet(SkillSet skillSet)
        {
            _context.SkillSets.Add(skillSet);
            _context.SaveChanges();
            return skillSet;
        }
        public EducationDetail AddEducationDetail(EducationDetail ed) {
            _context.EducationDetails.Add(ed);
            _context.SaveChanges();
            return ed;
        }
        public CompanyDetail AddCompanyDetail(CompanyDetail company)
        {
            _context.CompanyDetails.Add(company);
            _context.SaveChanges();
            return company;
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


        /*public List<Entities.TrainerDetail> GetAllDetails()
        {
            return _context.TrainerDetails.ToList();
        }*/

        /* public Entities.TrainerDetail RemoveTrainerDetailByName(string Name)
     {
         var search = _context.TrainerDetails.Where(td => td.Name == Name).FirstOrDefault();
         if (search != null)
         {
             _context.TrainerDetails.Remove(search);
             _context.SaveChanges();
         }

         return search;
     }*/



        public Entities.TrainerDetail DeleteTrainerDetail(string EmailId)
        {
            var res = _context.TrainerDetails.Where(e => e.EmailId == EmailId).FirstOrDefault();
            var User_Id = res.UserId;
            var tds = _context.TrainerDetails.Where(a => a.UserId == User_Id).FirstOrDefault();
            var ed = _context.EducationDetails.Where(b => b.UserId == User_Id).FirstOrDefault();
            var cmp = _context.CompanyDetails.Where(c => c.UserId == User_Id).FirstOrDefault();
            var ss = _context.SkillSets.Where(d => d.UserId == User_Id).FirstOrDefault();
                _context.SkillSets.Remove(ss);
                _context.CompanyDetails.Remove(cmp);
                _context.EducationDetails.Remove(ed);
                _context.TrainerDetails.Remove(tds);
            _context.SaveChanges();
            return tds;
        }

        public Entities.TrainerDetail UpdateTrainerDetail(Entities.TrainerDetail trainer)
        {
            _context.TrainerDetails.Update(trainer);
            _context.SaveChanges();
            return trainer;

        }
        public Entities.EducationDetail UpdateEducationDetail(Entities.EducationDetail education)
        {
            _context.EducationDetails.Update(education);
            _context.SaveChanges();
            return education;
        }
        public Entities.CompanyDetail UpdateCompanyDetail(Entities.CompanyDetail company)
        {
            _context.CompanyDetails.Update(company);
            _context.SaveChanges();
            return company;
        }

        public Entities.SkillSet UpdateSkillSet(Entities.SkillSet skills)
        {
            _context.SkillSets.Update(skills);
            _context.SaveChanges();
            return skills;
        }



        public bool Login(string EmailId, string Password)
        {
            var ll = _context.TrainerDetails;
            var mm = ll.FirstOrDefault(x => x.EmailId == EmailId);

            if (mm != null)
            {
                var obj = ll.FirstOrDefault(n => n.Password == Password);
                if (obj != null)
                {
                    Console.WriteLine("Logged in successfully");
                    return true;
                }
                else
                {
                    Console.WriteLine("You have Entered a Wrong Password, try again..");
                    return false;
                }
            }
            else
            {
                Console.WriteLine($"Something Wrong with your {mm.EmailId} input");
                return false;
            }
        }

    }

}







      









    