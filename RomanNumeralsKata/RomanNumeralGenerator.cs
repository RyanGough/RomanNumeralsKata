using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralsKata
{
    public class RomanNumeralGenerator
    {
        private IDictionary<int, string> _ValueToNumeralMap = new Dictionary<int, string>()
        {
            { 5, "V"},
            { 1, "I"},
        };

        public string Generate(int value)
        {
            if (value == 0)
            {
                return String.Empty;
            }
            var biggestFactor = _ValueToNumeralMap.First(x => x.Key <= value);
            return biggestFactor.Value + Generate(value - biggestFactor.Key);
        }
    }
}
