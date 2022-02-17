using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registrations
{
    public class UserRegistration
    {
        public void FirstName()
        {
             Console.WriteLine("Enter your First Name :- ");
             string instr = Console.ReadLine();
             const string name = @"^[A-Z]{1}[a-z]{3,9}$";
             Regex rg = new Regex(name);
             Console.WriteLine(rg.IsMatch(instr));
        }
        public void LastName()
        {
            Console.WriteLine("Enter your Last Name :- ");
            string instr = Console.ReadLine();
            const string name = @"^[A-Z]{1}[a-z]{3,15}$";
            Regex rg = new Regex(name);
            Console.WriteLine(rg.IsMatch(instr));
        }
        public void Email()
        {
            Console.WriteLine("Enter your Email Address :- ");
            string instr = Console.ReadLine();
            const string mail = @"^[a-zA-Z0-9.]+@[A-Za-z0-9]+.[A-Za-z]{2,4}$"; ;
            Regex rg = new Regex(mail);
            Console.WriteLine(rg.IsMatch(instr));
        }
    }
}
