using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralsKata;

namespace RomanNumeralGenerator_Test
{
    [TestClass]
    public class RomanNumeralGenerator_Test
    {
        [TestMethod]
        public void Generate_Given_0_Returns_EmptyString()
        {
            RomanNumeralGenerator generator = new RomanNumeralGenerator();
            string expectedResult = string.Empty;
            string actualResult = generator.Generate(0);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Generate_Given_1_Returns_I()
        {
            RomanNumeralGenerator generator = new RomanNumeralGenerator();
            string expectedResult = "I";
            string actualResult = generator.Generate(1);
            Assert.AreEqual(expectedResult, actualResult); 
        }
    }
}
