namespace RegexPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression!");

            ValidateInput obj = new ValidateInput();

            while(true)
            {
                Console.WriteLine("\nPlease select options: ");
                Console.WriteLine("1. Validate First Name.");
                Console.WriteLine("2. Validate Last Name.");
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
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}