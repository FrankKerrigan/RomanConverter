using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanConverter;

namespace RomanConverterTests
{
    /// <summary>
    /// Single bounds test
    /// </summary>
    [TestClass()]
    public class RomanNumeralGeneratorTests
    {
        [TestMethod()]
        public void Test_0()
        {
            int value = 0;
            string expected = "";
            RomanNumeralGenerator testObject = new RomanNumeralGenerator();
            var actual = testObject.Generate(value);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void Test_I()
        {
            int value = 1;
            string expected = "I";
            RomanNumeralGenerator testObject = new RomanNumeralGenerator();
            var actual = testObject.Generate(value);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Test_IV()
        {
            int value = 4;
            string expected = "IV";
            RomanNumeralGenerator testObject = new RomanNumeralGenerator();
            var actual = testObject.Generate(value);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Test_V()
        {
            int value = 5;
            string expected = "V";
            RomanNumeralGenerator testObject = new RomanNumeralGenerator();
            var actual = testObject.Generate(value);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void Test_IX()
        {
            int value = 9;
            string expected = "IX";
            RomanNumeralGenerator testObject = new RomanNumeralGenerator();
            var actual = testObject.Generate(value);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Test_X()
        {
            int value = 10;
            string expected = "X";
            RomanNumeralGenerator testObject = new RomanNumeralGenerator();
            var actual = testObject.Generate(value);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Test_XL()
        {
            int value = 40;
            string expected = "XL";
            RomanNumeralGenerator testObject = new RomanNumeralGenerator();
            var actual = testObject.Generate(value);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void Test_L()
        {
            int value = 50;
            string expected = "L";
            RomanNumeralGenerator testObject = new RomanNumeralGenerator();
            var actual = testObject.Generate(value);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Test_XC()
        {
            int value = 90;
            string expected = "XC";
            RomanNumeralGenerator testObject = new RomanNumeralGenerator();
            var actual = testObject.Generate(value);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Test_C()
        {
            int value = 100;
            string expected = "C";
            RomanNumeralGenerator testObject = new RomanNumeralGenerator();
            var actual = testObject.Generate(value);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Test_CD()
        {
            int value = 400;
            string expected = "CD";
            RomanNumeralGenerator testObject = new RomanNumeralGenerator();
            var actual = testObject.Generate(value);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Test_D()
        {
            int value = 500;
            string expected = "D";
            RomanNumeralGenerator testObject = new RomanNumeralGenerator();
            var actual = testObject.Generate(value);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Test_CM()
        {
            int value = 900;
            string expected = "CM";
            RomanNumeralGenerator testObject = new RomanNumeralGenerator();
            var actual = testObject.Generate(value);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Test_M()
        {
            int value = 1000;
            string expected = "M";
            RomanNumeralGenerator testObject = new RomanNumeralGenerator();
            var actual = testObject.Generate(value);
            Assert.AreEqual(expected, actual);
        }

    

}
}