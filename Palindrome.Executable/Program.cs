using System;

namespace Palindrome.Executable
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IPalindromeChecker palindromeChecker = new PalindromeReader();
                IConsoleOutput output = new ConsoleOutput();
                IConsoleInput inputChecker = new ConsoleReader();

                Console.WriteLine("Welcome to my application\n");
                Console.WriteLine("Input a word or sentence\n");

                var readLine = Console.ReadLine();
                if (readLine != null)
                {
                    var inputSequence = inputChecker.GetInput(readLine.ToLower());
                    var sequenceChecker = palindromeChecker.CheckSequence(inputSequence);
                    Console.WriteLine(output.Display(sequenceChecker));
                }

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
