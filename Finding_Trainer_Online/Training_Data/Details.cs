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
        public string Website
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
       
        /*public string details()
        {
            return $@"{User_Id},{Name},{Age},{Gender},{EmailId},{Password},{Contact_Number},{Location},{Website}";
        }
        public string Skill_Set()
        {
            return $@"{User_Id},{Skill_1}, {Skill_2}, {Skill_3}";
        }
        public string Company_Details()
        {
            return $@"{User_Id},{Company_Name}, {Experience_In_Years}, {Position}";
        }
        public string Education_Details()
        {
            return $@"{User_Id}, {Institution}, {Degree}, {Specialization},{Year_Of_Passing}";
        }
*/
        public string Trainer_Details()
        {
            return $@"{User_Id}, {Name}, {Age}, {Gender},{EmailId},{Password},{Contact_Number},{Location},{Website},{Skill_1}, {Skill_2}, {Skill_3}, {Company_Name},{Experience_In_Years},{Position},{Institution}, {Degree},{Specialization},{Year_Of_Passing}";
        }
    }
}