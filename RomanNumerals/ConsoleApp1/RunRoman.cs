using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    class RunRoman
    {
        static void Main()
        {
            RomanNumeral2 t = new RomanNumeral2();
            String current = "";
            for (int i = 1; i < 4000; i++)
            {
                current = t.ConvertInteger(i);
                Console.WriteLine(current + " = " + t.ConvertRomanNumeral(current));
            }
            return;
        }
    }
}
