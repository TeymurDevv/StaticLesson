using Changing.interFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Changing.Models
{
    internal class User:IAccount

    {
       
        public int Id;
        public string Fullname;
        public string Email;
        public string Password;
        public static int IdCount = 1;

        public User(string fullname, string email, string password)
        {
            Id = IdCount++;
            Fullname = fullname;
            Email = email;
            Password = password;
        }
        public void ShowingInfo()
        {
            Console.WriteLine($"{Fullname} {Password} {Id}");
        }
        public  bool checkPssword(string password)
        {
            if (password.Length > 8 &&
               password.Any(char.IsUpper) &&
               password.Any(char.IsLower) &&
               password.Any(char.IsDigit))
            {
               
                return true;
            }
            else
            {
               
                return false;
            }
        }
    }
}

