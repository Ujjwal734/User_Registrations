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
             Console.WriteLine("Enter your name :- ");
             string instr = Console.ReadLine();
             const string name = @"^[A-Z]{1}[a-z]{3,9}$";
             Regex rg = new Regex(name);
             Console.WriteLine(rg.IsMatch(instr));
        }
    }
}
