using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SantecExtensions;

namespace ConsoleAppNetFramework
{
    class Program
    {
        static void Main(string[] args)
        {

            String a = "10";
            a += ",34";

            IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var hasMoreThanThreeElements = numbers.HasMoreThanThreeElements();

            //if (StringIsNumeric(a))
            //{
            //    Console.WriteLine("Is Numeric");
            //}
            //else
            //{
            //    Console.WriteLine("Is not numeric");
            //}

            if (hasMoreThanThreeElements)
            {
                Console.WriteLine("has More Than Three Elements");
            }
            else
            {
                Console.WriteLine("has Less Than Three Elements");
            }

            if (a.IsNumeric())
            {
                Console.WriteLine("Is Numeric");
            }
            else
            {
                Console.WriteLine("Is not numeric");
            }

            Int32 x = new Int32();
            x = 10;
            int y = 20;
            string result = "risultato somma: ";
            int z = Somma(x, y);
            result += z;
            Console.WriteLine(result);
        }

        private static bool StringIsNumeric(string s)
        {
            float output;
            return float.TryParse(s, out output);
        }

        private static int Somma(int add1, int add2)
        {
            return add1 + add2;
        }
    }
}
