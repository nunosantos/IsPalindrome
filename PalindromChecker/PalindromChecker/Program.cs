using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;

namespace PalindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            IPalindromeDetector obj = new Palindrome();
            input = obj.GetInput();
            bool status = obj.IsPalindromic(input);
            obj.DisplayOutput(status);
        }
    }
}
