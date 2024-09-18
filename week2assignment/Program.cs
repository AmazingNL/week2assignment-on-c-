using Microsoft.VisualBasic;
using System.ComponentModel.Design;

namespace week2assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your age: ");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You are an adult");
            }
            else
            {
                Console.WriteLine("You are a minor");
            }
        }
    }
}

