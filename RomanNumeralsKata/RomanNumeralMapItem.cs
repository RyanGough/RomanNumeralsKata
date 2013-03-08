using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumeralsKata
{
    public class RomanNumeralMapItem
    {
        public int Value { get; private set; }
        public string RomanNumeral { get; private set; }

        public RomanNumeralMapItem(int value, string romanNumeral)
        {
            Value = value;
            RomanNumeral = romanNumeral;
        }
    }
}
