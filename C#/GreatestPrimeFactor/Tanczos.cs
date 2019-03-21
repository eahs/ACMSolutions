using System;
using System.Collections.Generic;
using ACMHelper;

namespace GreatestPrimeFactor2018
{
    class Program
    {    
        public static List<int> primes;
        
        public static int g (int k)
        {
            int greatestIndex = 0;

            for (int i = 0; i < primes.Count; i++)
            {
                if (k % primes[i] == 0 && i > greatestIndex)
                    greatestIndex = i;

                if (primes[i] > k)
                    break;
            }

            return primes[greatestIndex];
        }


        static void Main(string[] args)
        {
            Console.Write("Input: ");
            int n = Console.ReadLine().ToInteger();

            primes = ACM.GeneratePrimes(n);

            long sum = 0;
            for (int i = 2; i <= n; i++)
            {
                int gpf = g(i);
                sum += gpf;
            }

            Console.WriteLine("s({0}) = {1}", n, sum);
        }
    }
}
