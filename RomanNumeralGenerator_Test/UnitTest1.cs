using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralsKata;

namespace RomanNumeralGenerator_Test
{
    [TestClass]
    public class RomanNumeralGeneratorTestSuite
    {
        [TestMethod]
        public void Generate_Given_0_Returns_EmptyString()
        {
            RomanNumeralGenerator generator = new RomanNumeralGenerator();
            string expectedResult = string.Empty;
            string actualResult = generator.Generate(0);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
