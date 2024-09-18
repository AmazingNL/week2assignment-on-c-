using System.ComponentModel.Design;

namespace odd__number
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
            Console.WriteLine("enter your number: ");
            int number = int.Parse(Console.ReadLine());

            bool Even = IsEven(number);

            if (Even)
                Console.WriteLine(IsEven(number));
        }

        bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
                //Console.WriteLine("this is an Even number");
            }
            else {
                return false;
                //Console.WriteLine("this is an odd number");
            }
        }
        
    }
    
}
