using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Company_Detail
    {
        public Company_Detail() {
        
        }
        public int User_Id { get; set; }
        public string Company_Name { get; set; }
        public string Experience_In_Years { get; set; }
        public string Position { get; set; }


        public override string ToString()
        {
            return $"{Company_Name},{Experience_In_Years},{Position}";
        }
    }
}
