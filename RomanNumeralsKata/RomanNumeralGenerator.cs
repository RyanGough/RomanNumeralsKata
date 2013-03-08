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
            
            var biggestFactor = FindBiggestFactorRemaining(value);
            
            return biggestFactor.RomanNumeral + Generate(value - biggestFactor.Value);
        }
        
        private RomanNumeralMapItem FindBiggestFactorRemaining(int value)
        {
            var dictionaryBiggestFactor = _ValueToNumeralMap.First(x => x.Key <= value);
            RomanNumeralMapItem biggestFactor = new RomanNumeralMapItem(dictionaryBiggestFactor.Key, dictionaryBiggestFactor.Value);
            return biggestFactor;
        }
    }
}
