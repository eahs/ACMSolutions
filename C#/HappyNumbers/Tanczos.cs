using System;
using System.Collections.Generic;
using System.Linq;
using ACMHelper;

namespace HappyNumbers
{
    class Program
    {
        public static bool isHappy(int n)
        {
            List<int> sums = new List<int>();
            while (n > 1)
            {
                n = n.ToIntegerList().Select(k => k * k).Sum();

                if (sums.Contains(n)) return false;
                sums.Add(n);
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            int n = Console.ReadLine().ToInteger();

            List<int> happyNumbers = Enumerable.Range(1, 1000000).Where(k => isHappy(k)).ToList();

            int count = 0;
            for (int i = 0; i < happyNumbers.Count-1; i++)
            {
                if (happyNumbers[i]+1 == happyNumbers[i+1])
                {
                    count++;

                    if (count == n)
                    {
                        Console.WriteLine("Happy pair: {0}-{1}", happyNumbers[i], happyNumbers[i + 1]);
                    }
                }
            }

        }
    }
}
