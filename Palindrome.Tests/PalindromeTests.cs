using NUnit.Framework;
using Palindrome;

namespace Palindrome.Tests
{
    /// <summary>
    /// All tests meant to be performed on Palindrome Class
    /// </summary>
    [TestFixture]
    class PalindromeTests
    {
        /// <summary>
        /// Encapsulate PalindromeReader object
        /// </summary>
        private PalindromeReader _obj;

        /// <summary>
        /// construct and instantiate Palindrome Reader object
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            _obj = new PalindromeReader();
        }

        /// <summary>
        /// check if a sequence is valid, by returning true
        /// </summary>
        [Test]
        public void CheckSequence_ValidCondition_ReturnsTrue()
        { 
            //act
            bool condition = _obj.CheckSequence("anna");

            //assert
            Assert.IsTrue(condition);
        }

        /// <summary>
        /// deconstruct object
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            _obj = null;
        }
    }
}
