namespace Palindrome
{
    /// <summary>
    /// Console output interface
    /// </summary>
    public interface IConsoleOutput
    {
        /// <summary>
        /// Display abstraction
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        string Display(bool status);
    }
}