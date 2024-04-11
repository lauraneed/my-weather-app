using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace NumbersToWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a 4 - digit number");

            int number = 0;

            if (int.TryParse(Console.ReadLine(), out number)) 
            {
                if (number >= 1000 && number <= 9999)
                {
                    string result = ConvertToSpokenWords(number);
                  Console.WriteLine($"Spoken words representation: {result}");


                      else
                      {
                        Console.WriteLine("Please enter a valid 4 - digit number");
                      }

                      else
                      {
                        Console.WriteLine("no no no");
                      }
                     static string ConvertToSpokenWords( int number);
                    {
                        string[] units = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
                        string[] teens = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                        string[] tens = { "", "ten", "twenty", "thiry", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety", };

                        int thousands = number / 1000;
                        int hundreds = (number % 1000)/1000;
                        int tensDigit =( number % 1000)/10;
                        int unitsDigit = number % 10;

                        if (thousands > 0)
                        {
                            result += units[thousands] + "thousands";
                        }

                        if (hundreds > 0)
                        {
                            result += units[hundreds] + "hundreds";

                        }
                        if (tensDigit == 1 && unitsDigit > 0)
                        {
                            result += units[tensDigit - 1] + "";

                        }
                        else
                        {
                            result += tens[tensDigit] + "" + units[unitsDigit] + "";

                        }

                        return result.Trim();

                     



                    }
                }   
            
            }

        }
    }
}
