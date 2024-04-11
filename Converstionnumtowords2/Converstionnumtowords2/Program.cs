using System;
using System.Collections.Generic;

namespace Converstionnumtowords2
{
    public class Program
    {
        private static readonly Dictionary<int, string> NumberToWordMap = new Dictionary<int, string>
        {
          {0, "Zero"},
        {1, "One"},
        {2, "Two"},
        {3, "Three"},
        {4, "Four"},
        {5, "Five"},
        {6, "Six"},
        {7, "Seven"},
        {8, "Eight"},
        {9, "Nine"},
        {10, "Ten"},
        {11, "Eleven"},
        {12, "Twelve"},
        {13, "Thirteen"},
        {14, "Fourteen"},
        {15, "Fifteen"},
        {16, "Sixteen"},
        {17, "Seventeen"},
        {18, "Eighteen"},
        {19, "Nineteen"},
        {20, "Twenty"},
        {30, "Thirty"},
        {40, "Forty"},
        {50, "Fifty"},
        {60, "Sixty"},
        {70, "Seventy"},
        {80, "Eighty"},
        {90, "Ninety"},
        {100, "Hundred"},
        {1000, "Thousand"},
        {1000000, "Million"}
        };

        public static void Main()
        {
            Console.WriteLine(ConvertNumberToWords(149)); // Output: One Hundred forty nine
            Console.WriteLine(ConvertNumberToWords(1149)); // Output: One Thousand One Hundred Forty Nine
            Console.WriteLine(ConvertNumberToWords(42)); // Output: Forty Two
            Console.WriteLine(ConvertNumberToWords(890)); // Output: Eight Hundred Ninety
        }

        private static string ConvertNumberToWords(int number)
        {
            if (number == 0)
            {
                return NumberToWordMap[0];
            }

            int i = 0;
            while (i < NumberToWordMap.Count - 1 && number >= 1000)
            {
                number /= 1000;
                i += 3;
            }

            if (number >= 100)
            {
                return NumberToWordMap[number] + " " + NumberToWordMap[100];
            }

            if (number >= 20)
            {
                return NumberToWordMap[number - number % 10] + " " + NumberToWordMap[number % 10];
            }

            if (number >= 1)
            {
                return NumberToWordMap[number];
            }

            return "";
        }
    }

};






                    

