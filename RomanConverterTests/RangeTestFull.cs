using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanConverter;

namespace RomanConverterTests
{
    /// <summary>
    /// Test ALL numbers from 1 to 3999
    /// </summary>
    [TestClass]
    public class RangeTestFull
    {

        private List<KeyValuePair<int, string>> testvalues;

        [TestInitialize()]
        public void Initialize()
        {
            testvalues = new List<KeyValuePair<int, string>>();

            string[] lines = System.IO.File.ReadAllLines(@"RnumbersTo4K.txt");

            foreach (string line in lines)
            {
                var fields = line.Split('=');
                int intVal = Convert.ToInt32(fields[0]);

                testvalues.Add(new KeyValuePair<int, string>(intVal, fields[1]));
            }
        }

        [TestMethod]
        public void TestRange()
        {
            RomanNumeralGenerator testObject = new RomanNumeralGenerator();

            foreach (var pair in testvalues)
            {
                var expected = pair.Value;
                var actual = testObject.Generate(pair.Key);

                Assert.AreEqual(expected, actual);
            }
        }
    }
}
