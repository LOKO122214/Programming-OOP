using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterInterface
{
    internal class Register
    {
        private string username;
        private string password;
        private string email;
        public string Username
        {
            get { return username; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    username = value;
                else
                    Console.WriteLine("Not Value");

            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    email = value;
                else
                    Console.WriteLine("Not Value");

            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    username = value;
                else
                    Console.WriteLine("Not Value");
            }
        }

        public Register(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
        }


        bool streng = false;
        private bool StrengofPassword(string password, bool streng)
        {
            char[] numbers = ("1,2,3,4,5,6,7,8,9,0").ToCharArray();
            for (int i = 0; i < password.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (password.Contains(numbers[j]))
                    {
                        streng = true;
                    }
                }
            }
            return streng;
        }

        string newemail = "";
        private string emailchanger(string email, string newemail)
        {
            if (email.EndsWith(".com") || email.EndsWith(".bg"))
            {

                if (email.Contains("@"))
                {
                    string zvezda = "";
                    for (int i = 0; i < email.IndexOf("@"); i++)
                    {
                        zvezda += "*";
                    }
                    newemail = email.Replace(email.Substring(0, email.IndexOf("@")), zvezda);
                }
            }
            return newemail;
        }

        public void PrintData(string password, string username, string newemail)
        {
            if (streng == true)
            {
                Console.WriteLine($"Welcome {username}");
                Console.WriteLine($"Your email is save as:{newemail}");
            }
        }
    }
}
