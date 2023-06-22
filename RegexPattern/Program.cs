﻿namespace RegexPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression!");

            ValidateInput obj = new ValidateInput();

            while(true)
            {
                Console.WriteLine("\nPlease select options: \n");
                Console.WriteLine("1. Validate First Name.");
                Console.WriteLine("2. Validate Last Name.");
                Console.WriteLine("3. Validate Pincode.");
                Console.WriteLine("4. Validate Email.");
                Console.WriteLine("5. Validate Sample Email.");
                Console.WriteLine("6. Validate String.");
                Console.WriteLine("7. Validate Lowercase Sequence.");
                Console.WriteLine("8. Find HTML tags.");
                Console.WriteLine("9. Number of Occurrence.");
                Console.WriteLine("10. Find Valid file name with an image file type extension.");
                Console.WriteLine("11. Validate a website address format.");
                Console.WriteLine("12. Validate a Mobile Number.");
                Console.WriteLine("13. Validate Password.");
                Console.WriteLine("0. Exit.");

                int options = Convert.ToInt32(Console.ReadLine());

                switch (options)
                {
                    case 1:
                        obj.ValidFirstName();
                        break;
                    case 2:
                        obj.ValidLastName();
                        break;
                    case 3:
                        obj.ValidPincode();
                        break;
                    case 4:
                        obj.ValidEmail();
                        break;
                    case 5:
                        obj.ValidSampleEmail();
                        break;
                    case 6:
                        obj.ValidString();
                        break;
                    case 7:
                        obj.ValidLowercaseSequence();
                        break;
                    case 8:
                        obj.FindHtmlTags();
                        break;
                    case 9:
                        obj.CountOccurrences();
                        break;
                    case 10:
                        obj.ValidImageFileType();
                        break;
                    case 11:
                        obj.ValidWebsiteName();
                        break;
                    case 12:
                        obj.ValidMobilNumber();
                        break;
                    case 13:
                        obj.ValidPassword();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}