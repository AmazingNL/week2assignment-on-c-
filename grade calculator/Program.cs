using static System.Formats.Asn1.AsnWriter;

namespace grade_calculator
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
            // get input from the user
            Console.WriteLine("Enter your score (0-100): ");
            int score = int.Parse(Console.ReadLine());

            // call the method 
            Console.WriteLine(CalculateGrade(score));
            Console.WriteLine(GetGradeFeedback(score));
        }

        // creating the method CalculateGrade
        string CalculateGrade(int score)
        {
            switch (score)
            {
                case > 100:
                    return "Invalid input. Please enter a valid score";

                case >= 90:
                    return "Your grade is: A";

                case >= 80:
                    return "Your grade is: B";

                case >= 70:
                    return "Your grade is: C";

                case >= 60:
                    return "Your grade is: D";

                default:
                    return "Your grade is: F";
            }
        }

        // create the method GetGradeFeedback
        string GetGradeFeedback(int grade)
        {
            switch (grade)
            {
                case > 100:
                    return "";

                case >= 90:
                    return "Feedback: Excellent work!";

                case >= 80:
                    return "Feedback: Good job, but there’s room for improvement.";

                case >= 70:
                    return "Feedback: You passed, but consider reviewing the material.";
            
                case >= 60:
                    return "Feedback: Barely passed, you should work harder.";

                default:
                    return "Feedback: Failed, please seek help.";
            }

        }
    }


}
