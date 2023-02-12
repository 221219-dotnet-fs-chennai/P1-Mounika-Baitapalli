using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace BusinessLogic
{
    public class Validation
    {
        public static string IsValidEmailId(string EmailId)
        {
            string regex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            if (!Regex.IsMatch(EmailId, regex))
            {
                throw new Exception("Entered a wrong Email Pattern,try again!");
            }
            else
            {
                return EmailId;
            }
        }
        public static string IsGenderValid(string Gender)
        {
            string regex = @"(?:m|M|male|Male|f|F|female|Female|FEMALE|MALE|Not prefer to say)$";
            if (!Regex.IsMatch(Gender, regex))
            {
                throw new Exception("entered a wrong pattern,try again!");
            }
            else
            { 
                return Gender;
            }
        }

        public static string IsContactNumberValid(string Contact_Number)
        {
            string regex = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
            
                if(!Regex.IsMatch(Contact_Number, regex))
                {

                throw new Exception("Entered a Wrong Contact Number pattern,try again..");
                }
                else
                 { 
                   return Contact_Number;
                 }
            
            
        }
        public static string IsValidPassword(string Password)
        {
            string regex = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
            if (!Regex.IsMatch(Password, regex))
            {
                throw new Exception("Entered a Wrong Password Pattern,try again ");
            }
            else
            {
                return Password;
            }
        }
        public static string IsValidSProfile(string SProfile)
        {
            string regex = @"((http|https)://)(www.)?" +
                 "[a-zA-Z0-9@:%._\\+~#?&//=]" +
               "{2,256}\\.[a-z]" +
              "{2,6}\\b([-a-zA-Z0-9@:%" +
                   "._\\+~#?&//=]*)"; ;
            if (!Regex.IsMatch(SProfile, regex))
            {
                throw new Exception("entered a wrong pattern,try again!");
            }
            else 
            {
                return SProfile;
            }
        }



    }
}