using System.Numerics;

namespace simple_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start() {
            Console.WriteLine("Enter the first number: ");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double number2 = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Choose an operation (+, -, *, /): ");
            char operation = char.Parse(Console.ReadLine());

            switch (operation) {
                case '+': 
                    Console.WriteLine($"The answer is {AdditionMethod(number1, number2)}");
                    break;
                case '-':
                    Console.WriteLine($"The answer is {SubtractionMethod(number1, number2)}");
                    break;
                case '*':
                    Console.WriteLine($"The answer is {MultiplicationMethod(number1, number2)}");
                    break;
                case '/':
                    Console.WriteLine($"The answer is {DivisionMethod(number1, number2)}");
                    break;
            }
        }

        double AdditionMethod(double number1, double number2) { 
            return number1 + number2; 
        }
        double SubtractionMethod(double number1, double number2) {
            return number1 - number2;
        }

        double MultiplicationMethod(double number1, double number2) { 
            return number1 * number2;
        }

        double DivisionMethod(double number1, double number2) {
            return number1 / number2;
        }
    }
}
