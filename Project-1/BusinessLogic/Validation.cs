using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Validation
    {

        public static TimeSpan HandleTimeSpanNulls(TimeSpan? time)
        {
            if(time.HasValue)
            {
                return time.Value;
              
            }
            return TimeSpan.Zero;
        }
        public static TimeSpan StringToTime(string strTime)
        {

            TimeSpan time = TimeSpan.Zero;
            if (TimeSpan.TryParse(strTime, out time))
                return time;
            return TimeSpan.Zero;
                
                
           
        }
        /*Log.Logger.Information("enter a appropriate contact_Number");
                    System.Console.Write("Enter your Contact_Number: ");
                    string pattern2 = @"\(?\d{3}\)?(-|.|\s)?\d{3}(-|.)?\d{4}";

        string Contact_Number = System.Console.ReadLine();

                    if (Regex.IsMatch(Contact_Number, pattern2))
                    {
                        details.Contact_Number = Contact_Number;
                    }
                    else
                    {
                        System.Console.WriteLine("You have entered a Wrong pattern,try again...");
                        System.Console.ReadLine();
                    }
                   return "TSignUp";*/


    }
}