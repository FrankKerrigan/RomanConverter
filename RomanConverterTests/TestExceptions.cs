using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanConverter;

namespace RomanConverterTests
{
    /// <summary>
    /// Test Expected Exceptions are thrown
    /// </summary>
    [TestClass]
    public class TestExceptions
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeNumber()
        {
            RomanNumeralGenerator testObject = new RomanNumeralGenerator();

            var actual = testObject.Generate(-1);

            //Assert Exception
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TooLargeNumber()
        {
            RomanNumeralGenerator testObject = new RomanNumeralGenerator();

            var actual = testObject.Generate(4000);

            //Assert Exception
        }

    
         [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TooLargeNumber2()
        {
            RomanNumeralGenerator testObject = new RomanNumeralGenerator();

            var actual = testObject.Generate(999000);

            //Assert Exception
        }

    }
}
