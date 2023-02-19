using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Education_Detail
    {
        public Education_Detail() { 
        
        }
        public int User_Id { get; set; }
        public string Institution { get; set; }
        public string Degree { get; set; }
        public string Specialization { get; set; }
        public string Year_Of_Passing { get; set; }



        public override string ToString()
        {
            return $"{Institution},{Degree},{Specialization},{Year_Of_Passing}";
        }
    }
}
