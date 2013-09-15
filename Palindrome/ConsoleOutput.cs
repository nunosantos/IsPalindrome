namespace Palindrome
{
    public class ConsoleOutput : IConsoleOutput
    {  
        public string Display(bool status)
        {
            return status ? "Sequence is a Palindrome" : "Sequence is not a Palindrome";
        }
    }
}