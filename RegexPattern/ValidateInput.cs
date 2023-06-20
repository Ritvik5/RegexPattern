using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPattern
{
    public class ValidateInput
    {

        public void Validate(string data,string pattern) 
        {
            Regex regexObj = new Regex(pattern);
            if (regexObj.IsMatch(data))
            {
                Console.WriteLine("\nEntered input is correct!");
            }
            else
            {
                Console.WriteLine("\nEntered Input is incorrect!");
            }
        }

        public void ValidFirstName()
        {
            Console.WriteLine("\nEnter First Name: \n");
            string data = Console.ReadLine();
            string namePattern = "^[A-Z]{1}[A-Za-z]{3,}$";
            Validate(data, namePattern);
        }

        public void ValidLastName()
        {
            Console.WriteLine("\nEnter Last Name: \n");
            string data = Console.ReadLine();
            string pattern = "^[A-Z]{1}[A-Za-z]{3,}$";
            Validate(data, pattern);
        }

        public void ValidPincode()
        {
            Console.WriteLine("\nEnter Pin Code: \n");
            string data = Console.ReadLine();
            string pattern = "^[1-9][0-9]{2}[ ]?[0-9]{3}$";
            Validate(data, pattern);
        }

        public void ValidEmail()
        {
            Console.WriteLine("\nEnter Email: \n");
            string data = Console.ReadLine();
            string pattern = "^[A-Za-z0-9]+([-_.+][A-Za-z0-9]+)?[@][A-Za-z]+[.][A-Za-z]{2,3}([.][a-z]{2})?$";
            Validate(data, pattern);
        }

        public void ValidSampleEmail()
        {
            Console.WriteLine("\nEnter Sample Emails: \n");
            string data = Console.ReadLine();
            string pattern = "^[A-Za-z]{3}([+.-])?([0-9]{3})?[@][A-Za-z0-9]+[.][a-z]{3}([.][a-z]{2,})?$";
            Validate(data, pattern);
        }

        public void ValidString()
        {
            Console.WriteLine("\nEnter string that has an ‘a’ followed by two to three 'b'\n");
            string data = Console.ReadLine();
            string pattern = "[a][b]{2,3}";
            Validate(data, pattern);
        }
    }
}
