using System.Text;

namespace ConversionAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("please enter: 1149, 49, 890, 149");

             public const string V = "";
        public static string One_to_hund(int n)
        {
            string str = V;

            while (n != 0)
            {
                if (n == 1)
                {
                    str += str + "one";
                    n = 0;
                }
                else if (n == 2)
                {

                    str = str + "two";
                    n = 0;
                }
                else if (n == 3)
                {

                    str = str + "three";
                    n = 0;
                }

                else if (n == 4)
                {

                    str = str + "four";
                    n = 0;
                }

                else if (n == 5)
                {

                    str = str + "five";
                    n = 0;
                }
                else if (n == 6)
                {

                    str = str + "six";
                    n = 0;
                }
                else if (n == 7)
                {

                    str = str + "seven";
                    n = 0;
                }
                else if (n == 8)
                {

                    str = str + "eight";
                    n = 0;
                }
                else if (n == 9)
                {

                    str = str + "nine";
                    n = 0;
                }
                else if (n == 10)
                {

                    str = str + "ten";
                    n = 0;
                }
                else if (n == 11)
                {

                    str = str + "eleven";
                    n = 0;
                }
                else if (n == 12)
                {

                    str = str + "twelve";
                    n = 0;
                }
                else if (n == 13)
                {

                    str = str + "thirteen";
                    n = 0;
                }
                else if (n == 14)
                {

                    str = str + "fourteen";
                    n = 0;
                }
                else if (n == 15)
                {

                    str = str + "fifteen";
                    n = 0;
                }
                else if (n == 16)
                {

                    str = str + "sixteen";
                    n = 0;
                }
                else if (n == 17)
                {

                    str = str + "seventeen";
                    n = 0;
                }
                else if (n == 18)
                {

                    str = str + "eighteen";
                    n = 0;
                }
                else if (n == 19)
                {

                    str = str + "nineteen";
                    n = 0;
                }
                else if (n >= 20 && n < 30)
                {

                    str = str + "twenty";
                    n = n - 20;
                }
                else if (n >= 30 && n < 40)
                {

                    str = str + "thirty";
                    n = n - 30;
                }
                else if (n >= 40 && n < 50)
                {

                    str = str + "fourty";
                    n = n - 40;
                }
                else if (n >= 50 && n < 60)
                {

                    str = str + "fifty";
                    n = n - 50;
                }
                else if (n >= 60 && n < 70)
                {

                    str = str + "sixty";
                    n = n - 60;
                }
                else if (n >= 70 && n < 80)
                {

                    str = str + "seventy";
                    n = n - 70;
                }
                else if (n >= 70 && n < 80)
                {

                    str = str + "eighty";
                    n = n - 80;
                }
                else if (n >= 70 && n < 80)
                {

                    str = str + "ninety";
                    n = n - 90;
                }

                //return str;
            }
            return str;

            string convert(int n)
            {
                string str = "";
                while (n != 0)
                {
                    if (n > 1 && n < 100)
                    {
                        str = str + One_to_hund(n);
                        n = 0;
                    }
                    else if (n >= 100 && n < 1000)
                    {
                        str = str + "hundred";
                        n = n % 100;

                    }
                    else if (n > 1000 && n < 1000)
                    {
                        str = str + "thousand";
                        n = n % 1000;

                    }
                }
                return (str);




            }

            // static void Main(string[]args)
            {
                // string str;
                // int n;
                Program t = new Program();
            }

            //Console.WriteLine("please enter: 1149, 49, 890, 149");
            n = int.Parse(Console.ReadLine());
            str = convert(n);
            Console.WriteLine(str);
            Console.ReadLine();





        }
    }



}


        }
        

        public const string V = "";
        public static string One_to_hund(int n)
        {
            string str = V;

            while (n != 0)
            {
                if (n == 1)
                {
                    str += str + "one";
                    n = 0;
                }
                else if (n == 2)
                {

                    str = str + "two";
                    n = 0;
                }
                else if (n == 3)
                {

                    str = str + "three";
                    n = 0;
                }

                else if (n == 4)
                {

                    str = str + "four";
                    n = 0;
                }

                else if (n == 5)
                {

                    str = str + "five";
                    n = 0;
                }
                else if (n == 6)
                {

                    str = str + "six";
                    n = 0;
                }
                else if (n == 7)
                {

                    str = str + "seven";
                    n = 0;
                }
                else if (n == 8)
                {

                    str = str + "eight";
                    n = 0;
                }
                else if (n == 9)
                {

                    str = str + "nine";
                    n = 0;
                }
                else if (n == 10)
                {

                    str = str + "ten";
                    n = 0;
                }
                else if (n == 11)
                {

                    str = str + "eleven";
                    n = 0;
                }
                else if (n == 12)
                {

                    str = str + "twelve";
                    n = 0;
                }
                else if (n == 13)
                {

                    str = str + "thirteen";
                    n = 0;
                }
                else if (n == 14)
                {

                    str = str + "fourteen";
                    n = 0;
                }
                else if (n == 15)
                {

                    str = str + "fifteen";
                    n = 0;
                }
                else if (n == 16)
                {

                    str = str + "sixteen";
                    n = 0;
                }
                else if (n == 17)
                {

                    str = str + "seventeen";
                    n = 0;
                }
                else if (n == 18)
                {

                    str = str + "eighteen";
                    n = 0;
                }
                else if (n == 19)
                {

                    str = str + "nineteen";
                    n = 0;
                }
                else if (n >= 20 && n < 30)
                {

                    str = str + "twenty";
                    n = n - 20;
                }
                else if (n >= 30 && n < 40)
                {

                    str = str + "thirty";
                    n = n - 30;
                }
                else if (n >= 40 && n < 50)
                {

                    str = str + "fourty";
                    n = n - 40;
                }
                else if (n >= 50 && n < 60)
                {

                    str = str + "fifty";
                    n = n - 50;
                }
                else if (n >= 60 && n < 70)
                {

                    str = str + "sixty";
                    n = n - 60;
                }
                else if (n >= 70 && n < 80)
                {

                    str = str + "seventy";
                    n = n - 70;
                }
                else if (n >= 70 && n < 80)
                {

                    str = str + "eighty";
                    n = n - 80;
                }
                else if (n >= 70 && n < 80)
                {

                    str = str + "ninety";
                    n = n - 90;
                }

                //return str;
            }
            return str;

            string convert(int n)
            {
                string str = "";
                while (n != 0)
                {
                    if (n > 1 && n < 100)
                    {
                        str = str + One_to_hund(n);
                        n = 0;
                    }
                    else if (n >= 100 && n < 1000)
                    {
                        str = str + "hundred";
                        n = n % 100;

                    }
                    else if (n > 1000 && n < 1000)
                    {
                        str = str + "thousand";
                        n = n % 1000;

                    }
                }
                return (str);




            }

           // static void Main(string[]args)
            {
               // string str;
               // int n;
                Program t = new Program();
            }

            //Console.WriteLine("please enter: 1149, 49, 890, 149");
            n = int.Parse(Console.ReadLine());
            str = convert(n);
            Console.WriteLine(str);
            Console.ReadLine();





        }
    }  
           
        
    
}
