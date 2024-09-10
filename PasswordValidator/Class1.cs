using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordValidator
{
    public class Vald
    {
        public int ValidatePassword(string password)
        {
            int count = 0;
            if (password.Any(char.IsDigit))
                count++;
            if(password.Any(char.IsLower))
                count++;
            if (password.Any(char.IsUpper))
                count++;
             char[] ch = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '+', '=', '[', ']', '{', '}', '|', '\\', ':', ';', '"', '\'', '<', '>', ',', '.', '/', '?' ,'~','№'};
            int res = 0;
            foreach(char c in password)
            {
                foreach(char C in ch) 
                {
                    if(c == C)
                    {
                        res++;
                    } 
                }
            }
            if (res > 0) 
            { 
                count++;
            }
            if (password.Length > 10)
                count++;

            return count;
        }
    }
}
