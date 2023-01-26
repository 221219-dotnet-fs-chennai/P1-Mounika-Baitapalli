using System.Text.RegularExpressions;

namespace Trainer_Data
{
    public class Details
    {
        public Details()
        {

        }
       
       public int User_Id { get; set; }
        public string Name { 
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        public string Gender
        {
            get;
            set;
        }
        public string EmailId
        {
            get; set;
        }
        public string Password
        {
            get;
            set;
        }
        public string Contact_Number
        {
            get;
            set;
        }
        public string  Location
        {
            get;
            set;
        }
        public string SocialMedia_Profile
        {
            get;
            set;
        }

        public string Skill_1
        {
            get;
            set;
        }

        public string Skill_2
        {
            get;
            set;
        }

        public string Skill_3
        {
            get;
            set;
        }

        public string Company_Name
        {
            get;
            set;
        }

        public string Experience_In_Years
        {
            get;
            set;
        }

        public string Position
        {
            get;
            set;
        }

        public string Institution
        {
            get;
            set;
        }

        public string Degree
        {
            get;
            set;
        }

        public string Specialization
        {
            get;
            set;
        }
        public string Year_Of_Passing
        {
            get;
            set;
        }
       
        public string details()
        {
            return $@"{Name},{Age},{Gender},{EmailId},{Password},{Contact_Number},{Location},{SocialMedia_Profile}";
        }
        public string Skill_Set()
        {
            return $@"{Skill_1}, {Skill_2}, {Skill_3}";
        }
        public string Company_Details()
        {
            return $@"{Company_Name}, {Experience_In_Years}, {Position}";
        }
        public string Education_Details()
        {
            return $@" {Institution}, {Degree}, {Specialization},{Year_Of_Passing}";
        }

        public string Trainer_Details()
        {
            return $@"{Name}, {Age}, {Gender},{EmailId},{Password},{Contact_Number},{Location},{SocialMedia_Profile},{Skill_1}, {Skill_2}, {Skill_3}, {Company_Name},{Experience_In_Years},{Position},{Institution}, {Degree},{Specialization},{Year_Of_Passing}";
        }
    }
}