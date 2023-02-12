using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{

     
    public class Skill_Set
    {
        public Skill_Set()
        { 
        
        }
        public int User_Id { get; set; }
        public string Skill_1 { get; set; }
        public string Skill_2 { get; set; }
        public string Skill_3 { get; set; }

        public override string ToString()
        {
            return $"{Skill_1},{Skill_2},{Skill_3}";
        }
        

        
    }
}
