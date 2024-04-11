using System.Text;

namespace Assignment2conversion
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           // string NumberToWords(int num)
            {
                {
                    Console.WriteLine(NumberToWords(142));
                    Console.WriteLine(NumberToWords(1142));
                    Console.WriteLine(NumberToWords(42));
                    Console.WriteLine(NumberToWords(890));
                }

                static string NumberToWords(int number)
                {
                    if (number == 0)
                        return "Zero";

                    if (number < 0)
                        return "Minus " + NumberToWords(Math.Abs(number));

                    string words = "";

                    if ((number / 1000) > 0)
                    {
                        words = NumberToWords(number / 1000) + " Thousand ";
                        number = 1000;
                    }

                    if ((number / 100) > 0)
                    {
                        words = NumberToWords(number / 100) + " Hundred ";
                        number  = 100;
                    }

                    if (number > 0)
                    {
                        if (words != "")
                            words = "and ";
                       
                        var unitsMap = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                        var tensMap = new[] { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

                        if (number < 20)
                            words = unitsMap[number];
                        else
                        {
                           
                            if ((number % 10) > 0)
                                words = "-" + unitsMap[number % 10];
                        }
                    }

                    return words;
                }
            }
        }
    }
}

