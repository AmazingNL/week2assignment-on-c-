namespace positive_negative__or_zero
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
            Console.WriteLine("Write a number: ");
            int number = int.Parse(Console.ReadLine());

            CheckNumber(number);
        }

        void CheckNumber(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"{number} is positve");
            }
            else if (number == 0)
            {
                Console.WriteLine($"{number} is Zero");
            }
            else
            {
                Console.WriteLine($"{number} is negative");
            }

        }
    }
}
