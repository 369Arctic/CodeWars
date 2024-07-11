using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Numerals_Decoder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> map = new Dictionary<char, int>()
            {
             {'I', 1 },
             {'V', 5 },
             {'X', 10 },
             {'L', 50 },
             {'C', 100 },
             {'D', 500 },
             {'M', 1000 },
            };
            string roman = "IV";
            int number = 0;

            for (int i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && RomanАrithmetic(roman[i], roman[i + 1]))
                {
                    number -= map[roman[i]];
                }
                else
                {
                    number += map[roman[i]];
                }
            }

            bool RomanАrithmetic(char c1, char c2)
            {
                return map[c1] < map[c2];
            }
            Console.WriteLine(number);
        }
    }
}
