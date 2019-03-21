using System;
using System.Collections.Generic;
using System.Linq;
using ACMHelper;

namespace SmoothNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter k and n: ");
            List<int> nums = Console.ReadLine().ToIntegerList();

            int count = 0;

            ACM.GeneratePrimes(nums[1]);  // We need to generate a massive list of primes first

            for (int i = 2; i <= nums[1]; i++)
            {
                if (i.GetPrimeFactors().Max() <= nums[0])  // Uses ACMHelper GetPrimeFactors integer extension method
                {
                    count++;
                }
            }

            Console.WriteLine("{0}", count + 1);  // Literally because we also include 1 as a k-smooth number

        }
    }
}
