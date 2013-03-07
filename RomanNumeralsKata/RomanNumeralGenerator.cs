using System;
using System.Collections.Generic;

namespace RomanNumeralsKata
{
    public class RomanNumeralGenerator
    {
        private IDictionary<int, string> _ValueToNumeralMap = new Dictionary<int, string>()
        {
            { 1, "I"},
            { 2, "II"},
            { 5, "V"},
        };

        public string Generate(int value)
        {
            if (value == 0)
            {
                return String.Empty;
            }
            return _ValueToNumeralMap[value];
        }
    }
}
