using System.Collections.Generic;
using System.Linq;

namespace Palindrome
{
    public class PalindromeReader : IPalindromeChecker
    {
        /// <summary>
        /// property which stores an input sequence
        /// </summary>
        private readonly Stack<char> _buffer;

        public PalindromeReader()
        {
            _buffer = new Stack<char>();
        }

        /// <summary>
        /// Evaluates each character in a string, and identifies if it repeats or not
        /// </summary>
        /// <param name="inputSequence"></param>
        /// <returns>Returns true if the user inputs the same sequence A-B-A</returns>
        public bool CheckSequence(string inputSequence)
        {
            GetValue(inputSequence);

            //compares each element in the array
            for (int i = 0; i < inputSequence.Count(); i++)
            {
                if (_buffer.Pop().CompareTo(inputSequence.ElementAt(i)) != 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void GetValue(string inputSequence)
        {
            //pushes characters into the stack
            foreach (char element in inputSequence)
            {
                _buffer.Push(element);
            }
        }
    }
}