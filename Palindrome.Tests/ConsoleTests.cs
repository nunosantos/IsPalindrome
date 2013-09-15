using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Palindrome.Tests
{
    [TestFixture]
    class ConsoleTests
    {
        private ConsoleOutput _obj = null;
        private ConsoleReader _obj2 = null;

        [SetUp]
        public void SetUp()
        {
            _obj = new ConsoleOutput();
            _obj2 = new ConsoleReader();
        }

        [Test]
        public void Display_ValidateSequence_ReturnTrue()
        { 
            var expected = true;
            _obj.Display(expected);

            Assert.IsTrue(expected);
        }

        [Test]
        public void Display_TrueString_ReturnString()
        {
            var trueCondition = true;
            var expected = "Sequence is a Palindrome";
            _obj.Display(trueCondition);
            StringAssert.Contains(expected, _obj.Display(trueCondition));
        }

        [Test]
        public void Display_FalseString_ReturnString()
        {
            var falseCondition = false;
            var expected = "Sequence is not a Palindrome";
            _obj.Display(falseCondition);
            StringAssert.Contains(expected, _obj.Display(falseCondition)); 
        }

        [Test]
        public void GetInput_InputStringValidation_ReturnString()
        {
            var expected = "hello";
            var actual = _obj2.GetInput("hello");

            Assert.AreSame(expected, actual); 
        }

        [TearDown]
        public void TearDown()
        {
            _obj = null;
            _obj2 = null;
        }
    }
}
