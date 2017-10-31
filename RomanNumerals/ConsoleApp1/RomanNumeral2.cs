using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class RomanNumeral2
    {
        public string[] letters = new string[] { "M", "CM", "D", "CD","C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        int[] numbers = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        public int getRomanValue(string roman)
        {
            int index = Array.IndexOf(letters,roman);
            int value = -1;
            if (index >= 0)
            {
                value = numbers[index];
            }
            return value;
        }

        public string getRomanNumeral(int value)
        {
            int index = Array.IndexOf(numbers, value);
            string roman = "";
            if (index > 0)
            {
                roman = letters[index];
            }
            return roman;
        }

        public int ConvertRomanNumeral(string roman)
        {
            int value = 0;
            int i = 0;
            while (i < roman.Length)
            {
                int first = getRomanValue(roman[i].ToString());
                if (i < roman.Length - 1)
                {
                    int second = getRomanValue(roman[i + 1].ToString());
                    if (first < second)
                    {
                        value += second - first;
                        i++;
                    }
                    else
                    {
                        value += first;
                    }
                }
                else
                {
                    value += first;
                }
                i++;
            }
            return value;
        }

        public string ConvertInteger(int value)
        {
            string roman = "";
            int currentLetter = 0;
            while (value > 0)
            {
                int modResult = value / getRomanValue(letters[currentLetter]);
                for (int i = 0; i < modResult; i++)
                {
                    roman += letters[currentLetter];
                }
                value -= getRomanValue(letters[currentLetter]) * modResult;
                currentLetter++;
            }
            return roman;
        }

        public RomanNumeral2()
        {

        }
    }
}
