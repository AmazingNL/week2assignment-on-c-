namespace vowel_checker
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
            Console.WriteLine("Enter your alphabet letter: ");
            
            char letter = char.ToUpper(char.Parse(Console.ReadLine()));

            if (char.IsLetter(letter))
            {

                if (IsLetterVowel(letter))
                {
                    Console.WriteLine($"{letter} is a vowel");
                }
                else
                {
                    Console.WriteLine($"{letter} is a consonant");
                }
            }
            else {
                Console.WriteLine("Error: Input is not a letter");
            }

        }

        bool IsLetterVowel(char letter)
        {
            switch (letter)
            {
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    return true;
                default:
                    return false;
            }
        }
    }
}
