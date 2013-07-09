using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromeChecker
{
    /// <summary>
    /// Provides methods to get user input and check if it is palindromic
    /// </summary>
    public class Palindrome : IPalindromeDetector
    {
        private string input;
        /// <summary>
        /// Gets input from the console
        /// </summary>
        /// <returns>Returns the input string</returns>
        public string GetInput()
        {
            input = Console.ReadLine();
            return input;
        }

        /// <summary>
        /// Evaluates each character in a string, and identifies if it repeats or not
        /// </summary>
        /// <param name="inputSequence">The input sequence to be validated</param>
        /// <returns>Returns true if the user inputs the same sequence A-B-A</returns>
        public bool IsPalindromic(string inputSequence) 
        {
            Stack<char> buffer = new Stack<char>();
            foreach (char element in inputSequence)
            {
                buffer.Push(element);
            }

            for (int i = 0; i < inputSequence.Count(); i++)
            {
                if (buffer.Pop().CompareTo(inputSequence.ElementAt(i)) == 0)
                    continue;
                else
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Output the result to a console application
        /// </summary>
        /// <param name="status">if the input result is palindromic or not</param>
        public void DisplayOutput(bool status)
        {
            if (status == true)
            {
                Console.WriteLine("Sequence is a palindrome");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sequence is not a palindrome");
                Console.ReadLine();
            }
        }
    }
}
