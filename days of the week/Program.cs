namespace days_of_the_week
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
            Console.Write("Enter a number (1-7) to get the day of the week: ");
            int dayNumber = int.Parse(Console.ReadLine());
            string day = GetDayOfWeek(dayNumber);
            Console.WriteLine(day);
        }

        string GetDayOfWeek(int dayNumber) {
            if (dayNumber == 1)
            {
                return "The day is: Monday";
            }
            else if (dayNumber == 2)
            {
                return "The day is: Tuesday";
            }
            else if (dayNumber == 3)
            {
                return "The day is: Wednesday";
            }
            else if (dayNumber == 4)
            {
                return "The day is: Thursday";
            }
            else if (dayNumber == 5)
            {
                return "The day is: Friday";
            }
            else if (dayNumber == 6) { 
                return "The day is: Saturday";
            }
            else if (dayNumber == 7) { 
                return "The day is: Sunday";
            }
            else
            {
                return "The day is: Invalid day number";
            }
        }
    }
}
