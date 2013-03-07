using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralsKata;

namespace RomanNumeralGenerator_Test
{
    [TestClass]
    public class RomanNumeralGenerator_Test
    {
        private RomanNumeralGenerator generator = new RomanNumeralGenerator();

        [TestMethod]
        public void Generate_Given_0_Returns_EmptyString()
        {
            string expectedResult = string.Empty;
            string actualResult = generator.Generate(0);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Generate_Given_1_Returns_I()
        {
            string expectedResult = "I";
            string actualResult = generator.Generate(1);
            Assert.AreEqual(expectedResult, actualResult); 
        }

        [TestMethod]
        public void Generate_Given_5_Returns_V()
        {
            string expectedResult = "V";
            string actualResult = generator.Generate(5);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
