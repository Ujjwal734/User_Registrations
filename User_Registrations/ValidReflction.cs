using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registrations
{
    public class ValidReflction
    {

        public static string FirsName = "^[A-Z]{1}[a-zA-Z0-9]{2,29}$";
        public static string LastName = "^[A-Z]{1}[a-zA-Z0-9]{2,29}$";
        public static string regex_email = "^[a-z0-9]+(.[a-z0-9]+)?@[a-z]+[.][a-z]{2,3}(.[a-z]{2})?$";
        public static string regex_mobile = "^[1-9][0-9]{1,2}[ ][0-9]{10}$";

        public static string regex_passwordRule1 = "^[a-zA-Z0-9]{8,}$";

        public bool ValidateFirstName(string uName)
        {
            return Regex.IsMatch(uName, FirsName);
        }
        public bool ValidateLasttName(string uName)
        {
            return Regex.IsMatch(uName, FirsName);
        }
        public bool ValidateEmail(string uName)
        {
            return Regex.IsMatch(uName, regex_email);
        }
        public bool ValidateMobileNumber(string uName)
        {
            return Regex.IsMatch(uName, regex_mobile);
        }

        public bool ValidatePasswordRule1(string uName)
        {
            return Regex.IsMatch(uName, regex_passwordRule1);
        }
    }
}
