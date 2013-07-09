using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromeChecker
{
    interface IPalindromeDetector
    {
        bool IsPalindromic(string inputSequence);
        string GetInput();
        void DisplayOutput(bool status);
    }
}
