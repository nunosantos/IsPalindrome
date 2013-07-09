using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace PalindromeChecker.Tests
{
    [TestFixture]
    public class PalindromeTests
    {
        private Palindrome obj = null;

        [SetUp]
        public void SetUp()
        {
            obj = new Palindrome();
        }

        [Test]
        public void IsPalindrome_ValidInput_ReturnsTrue()
        { 
            //act
            bool condition = obj.IsPalindromic("anna");

            //assert
            Assert.IsTrue(condition, "Test if condition is true");
        }

        [TearDown]
        public void TearDown()
        {
            obj = null;
        }
    }
}
