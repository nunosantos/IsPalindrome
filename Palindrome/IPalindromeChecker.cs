namespace Palindrome
{
    /// <summary>
    /// Palindrome Interface
    /// </summary>
    public interface IPalindromeChecker
    {
        /// <summary>
        /// checks sequence if an input has been provided
        /// </summary>
        /// <param name="inputSequence"></param>
        /// <returns></returns>
        bool CheckSequence(string inputSequence);
    }
}