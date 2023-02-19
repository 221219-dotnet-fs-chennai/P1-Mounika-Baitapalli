using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Models
{
    public class Trainer_Detail
    {

        public Trainer_Detail()
        {

        }
        public int User_Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string Contact_Number { get; set; }
        public string Location { get; set; }
        public string SocialMedia_Profile { get; set; }






        public override string ToString()
        {
            return $"{User_Id},{Name},{Age},{Gender},{EmailId},{Password},{Contact_Number},{Location},{SocialMedia_Profile}";
        }
    }
}


