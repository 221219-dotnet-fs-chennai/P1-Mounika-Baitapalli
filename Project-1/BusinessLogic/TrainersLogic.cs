using DataFluentApi;
using DataFluentApi.Entities;
using Models;
using System.Text.RegularExpressions;


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

        public Education_Detail AddEducationDetail(Education_Detail edu)
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
        }

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

       /* public IEnumerable<Trainer_Detail> GetAllDetails()
        {
            return Mapper.TMap(_repo.GetAllDetails());
        }*/


        public Trainer_Detail DeleteTrainerDetail(int User_Id)
        {
            var deleteobj = _repo.DeleteTrainerDetail(User_Id);
            if (deleteobj != null)
            {
                return Mapper.TMap(deleteobj);

            }
            else
                return null;
        }

        /*public Trainer_Detail RemoveTrainerDetailByName(string td)
        {
            var delete = _repo.RemoveTrainerDetailByName( td);
            if (delete != null)
                return Mapper.TMap(delete);
            else
                return null;


        }
        public Education_Detail DeleteEducationDetailByUserId(int ed, int User_Id)
        {
            var del = _repo.DeleteEducationDetail(ed);
            if (del != null)
                return Mapper.EdMap(del);
            else
                return null;

            public Skill_Set DeleteSkillsByUserId(int ss)
            {
                var del = _repo.DeleteSkillSets(ss);
                if (del != null)
                    return Mapper.SkillMap(del);
                else
                    return null;
            }
            public Company_Detail DeleteCompanyDetailsByUserId(int cd, int User_Id)
            {
                var cdd = _repo.DeleteCompanyDetail(cd);

                if (cdd != null)
                {
                    return Mapper.CmpMap(cdd);
                }
                else
                    return null;
            }*/

        public Trainer_Detail UpdateTrainerDetail(int User_Id, Trainer_Detail td)
        {
            var trainer = (from tds in _repo.GetAllTrainers()
                           where tds.UserId == User_Id
                           select tds).FirstOrDefault();

            if (trainer != null)
            {

                trainer.UserId = User_Id;
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

        public Education_Detail UpdateEducationDetail(int User_Id, Education_Detail ed)
        {
            var edu = (from num in _repo.GetEducation_Details()
                       where num.UserId == User_Id
                       select num).FirstOrDefault();
            if (edu != null)
            {
                edu.UserId = User_Id;
                edu.Institution = ed.Institution;
                edu.Degree = ed.Degree;
                edu.Specialization = ed.Specialization;
                edu.YearOfPassing = ed.Year_Of_Passing;


                edu = _repo.UpdateEducationDetail(edu);

            }
            return Mapper.EdMap(edu);
        }

        public Skill_Set UpdateSkillSet(int User_Id, Skill_Set ss)
        {
            var sk = (from obj in _repo.GetSkill_Sets() where obj.UserId == User_Id 
                      select obj).FirstOrDefault();
            if (sk != null)
            {
                sk.UserId = User_Id;
                sk.Skill1 = ss.Skill_1;
                sk.Skill2 = ss.Skill_2;
                sk.Skill3 = ss.Skill_3;

                sk = _repo.UpdateSkillSet(sk);

            }
            return Mapper.SkillMap(sk);
        }
        public Company_Detail UpdateCompanyDetail(int User_Id, Company_Detail cmp)
        {
            var company = (from objj in _repo.GetCompany_Details() where objj.UserId == User_Id 
                           select objj).FirstOrDefault();
            
            
                if (company != null)
                {
                    company.UserId = User_Id;
                    company.CompanyName = cmp.Company_Name;
                    company.ExperienceInYears = cmp.Experience_In_Years;
                    company.Position = cmp.Position;

                    company = _repo.UpdateCompanyDetail(company);
                }
                return Mapper.CmpMap(company);
            
           
        }
    }
}




             /*public Trainer_Detail GetTrainerDetailsByUser_Id(int id)
            {
                var search = _repo.GetTrainer_Details().Where(td => td.UserId == id).FirstOrDefault();
                return Mapper.TMap(search);
            }*/


        

    
