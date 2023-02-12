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




        /*public Entities.TrainerDetail RemoveTrainerDetailByName(string Name)
        {
            var search = _context.TrainerDetails.Where(td => td.Name == Name).FirstOrDefault();
            if (search != null)
            {
                _context.TrainerDetails.Remove(search);
                _context.SaveChanges();
            }

            return search;
        }
        public Entities.EducationDetail DeleteEducationDetail(int User_Id) { 

            var edd=_context.EducationDetails.Where(ed=>ed.UserId==User_Id).FirstOrDefault();
            if (edd != null)
            {
                _context.EducationDetails.Remove(edd);
                _context.SaveChanges();
            }
            return edd;
        }

        public Entities.CompanyDetail DeleteCompanyDetail(int User_Id)
        {
            var compp=_context.CompanyDetails.Where(cd=>cd.UserId==User_Id).FirstOrDefault();    
            if(compp != null)
            {
                _context.CompanyDetails.Remove(compp);
                _context.SaveChanges();
            }
            return compp;
        }
        public Entities.SkillSet DeleteSkillSet(int User_Id)
        {
            var skills=_context.SkillSets.Where(ss=>ss.UserId==User_Id).FirstOrDefault();
            if(skills != null) {
                _context.SkillSets.Remove(skills);
                _context.SaveChanges();

            }
            return skills;
        }*/

        //Entities.TrainerDetail DeleteTrainerDetail(int User_Id);

        public Entities.TrainerDetail DeleteTrainerDetail(int User_Id)
        {
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

    }

}







      









    