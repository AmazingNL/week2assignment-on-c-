namespace maxnumber
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
            Console.WriteLine("Enter first number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int number3 = int.Parse(Console.ReadLine());

            int maxnumber = FindMax(number1, number2, number3); 
            Console.WriteLine($"The largest number is {maxnumber}");
        }

        int FindMax(int number1, int number2, int number3)
        {
            if (number1 > number2 && number1 > number3)
            {
                return number1;
            }
            else if (number2 > number1 && number2 > number3)
            {
                return number2;
            }
            else
            {
                return number3;
            }
        }
    }
}
