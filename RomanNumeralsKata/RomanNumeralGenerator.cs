using System;

namespace RomanNumeralsKata
{
    public class RomanNumeralGenerator
    {
        public string Generate(int value)
        {
            if (value == 0)
            {
                return String.Empty;
            }
            if (value == 1)
            {
                return "I";
            }
            return "V";
        }
    }
}
