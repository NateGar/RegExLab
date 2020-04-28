using System;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace RegExLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answer1 = IsValidName("Nate");
            Console.WriteLine(answer1);
            bool answer2 = IsValidEmail("Nate@nate.com");
            Console.WriteLine(answer2);
            bool answer3 = IsPhoneNum("231-670-9892");
            Console.WriteLine(answer3);
            bool answer4 = IsValidDate("25/05/1984");
            Console.WriteLine(answer4);
            
        }
        public static bool IsValidName(string userName)
        {
            string strRegex = @"^[A-Z][a-zA-Z]{0,31}$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(userName))
            {
                return true;
            }
            else
                return false;
        }
        public static bool IsValidEmail(string inputEmail)
        {
            string strRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            Regex re = new Regex(strRegex, RegexOptions.IgnoreCase);

            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        public static bool IsPhoneNum(string phoneNum)
        {
            string strRegex = @"(^[0-9]{3}-[0-9]{3}-[0-9]{4}$)";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(phoneNum))
            {
                return true;
            }
            else
                return false;
        }
        public static bool IsValidDate(string inputDate)
        {
            string strRegex = (@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");

            Regex re = new Regex(strRegex, RegexOptions.IgnoreCase);

            if (re.IsMatch(inputDate))
                return (true);
            else
                return (false);
        }

    }
}
