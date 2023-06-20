﻿using System;
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
    }
}
