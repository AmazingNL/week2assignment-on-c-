namespace prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number: ");
            int number = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 2; i <= (number - 1); i++)
            {

                if (number % i == 0)
                {
                    count++;
                }
            }
            return (count == 0);
        }
    }
}
