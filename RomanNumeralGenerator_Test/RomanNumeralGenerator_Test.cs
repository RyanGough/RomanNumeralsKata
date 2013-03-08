using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralsKata;
using System.Collections.Generic;

namespace RomanNumeralGenerator_Test
{
    [TestClass]
    public class RomanNumeralGenerator_Test
    {
        private RomanNumeralGenerator generator = new RomanNumeralGenerator();

        private IDictionary<int, string> _ValueToExpectedRomanNumeralMap = new Dictionary<int, string>()
        {
            {0, ""},
            {1, "I"},
            {2, "II"},
            {3, "III"},
            {4, "IV"},
            {5, "V"},
            {6, "VI"},
            {7, "VII"},
            {8, "VIII"},
            {9, "IX"},
            {10, "X"},
            {20, "XX"},
            {40, "XL"},
            {50, "L"},
            {90, "XC"},
            {100, "C"},
            {400, "CD"},
            {500, "D"},
            {900, "CM"},
            {1000, "M"},
            {3999, "MMMCMXCIX"}
        };

        [TestMethod]
        public void Generate_GivenValue_ReturnsCorrectRomanNumeral()
        {
            foreach (var testData in _ValueToExpectedRomanNumeralMap)
            {
                int input = testData.Key;
                string expectedResult = testData.Value;
                string actualResult = generator.Generate(input);
                Assert.AreEqual(expectedResult, actualResult);
            }
        }
    }
}
