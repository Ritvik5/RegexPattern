namespace RegexPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression!");

            ValidateInput obj = new ValidateInput();
            obj.ValidFirstName();
        }
    }
}