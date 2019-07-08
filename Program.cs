using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            long total = Factorial(1, 1000, 1);

            Console.WriteLine("The factorial of 1000 is " + total);
        }

        public static long Factorial(long currentTotal, int endIndex, int currentIndex)
        {
            Console.WriteLine("Current Index: "+ currentIndex);
            Console.WriteLine("Current Total: " + currentTotal);
            if(currentTotal == 0)
            {
                return currentTotal;
            }
            Console.WriteLine();
            if(currentIndex> endIndex)
            {
                return currentTotal;
            }
            else
            {
                currentTotal *= currentIndex;

                currentIndex++;

                return Factorial(currentTotal, endIndex, currentIndex);
            }
        }
    }
}
