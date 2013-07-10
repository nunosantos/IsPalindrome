using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindromico
{
    interface IConsole
    {
        string GetInput();
        bool IsPalindromic(string inputSequence);
        void DisplayOutput(bool status);
        void WaitInput();
    }
}
