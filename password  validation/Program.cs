namespace password__validation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            Console.Write("Enter your password: ");
            string input = Console.ReadLine();



            if (IsMoreThan8(input) && IsUpperCase(input) && IsNumber(input))
            {
                Console.WriteLine("Password is Valid");
            }
            else if (!IsMoreThan8(input))
            {
                Console.WriteLine("Password is not valid, it should be at least 8 characters long");
            }
            else if (!IsUpperCase(input))
            {
                Console.WriteLine("Password is not valid, there should be an uppercase");
            }
            else if (!IsNumber(input)) {
                Console.WriteLine("Password is not valid, there is no number");
            }
        }

        bool IsMoreThan8(string input){
            if (input.Length < 8)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        bool IsUpperCase(string input) {
            if (input.Any(char.IsUpper))
            {
                return true;
            }
            else { 
                return false;
            }
        }

        bool IsNumber(string input) {
            if (input.Any(char.IsNumber))
            {
                return true;
            }
            else { 
                return false;
            }
        }
    }
}
