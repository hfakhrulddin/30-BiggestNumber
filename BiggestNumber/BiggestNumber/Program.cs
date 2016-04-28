using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindLargestNumber(6, 3, 9));
            Console.WriteLine(FindLargestNumber(6));
            Console.WriteLine(FindLargestNumber(6, 3, 9, 2, 5, 8));
            Console.ReadLine();
        }

        /// <summary>
        /// Find the largest number in a variable list 
        /// </summary>
        /// <param name="a">first parameter. Required.</param>
        /// <param name="numbers">variable list of longs</param>
        /// <returns></returns>
        public static long FindLargestNumber(long a, params long[] numbers)
        {
            // assume that the first value is the biggest
            long biggest = a;

            // loop through all the arguments passed
            foreach (long x in numbers)
            {
                // check if the current number is the biggest
                if (x > biggest)
                    biggest = x;
            }

            return biggest;
        }
    }
}
