namespace target_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a target number :");
            int targetNumber = int.Parse(Console.ReadLine());

            int count = 0;
            int num;

            do
            {
                Console.WriteLine("enter a number:");
                num = int.Parse(Console.ReadLine());

                if (num == targetNumber)
                {
                    count++;
                }
            }
            while (num != 0);
            Console.WriteLine($"count is {count}");
        }
    }
}
