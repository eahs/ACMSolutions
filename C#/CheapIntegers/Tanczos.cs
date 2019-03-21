using System;
using System.Collections.Generic;
using ACMHelper;

namespace CheapIntegers
{
    class Program
    {
        public static List<int> primes;

        public static int CalculateCost(int k)
        {
            if (k < 3) return k;

            foreach(int p in primes)
            {
                if (k == p)
                    return 1 + CalculateCost(p - 1);

                if (k % p == 0)
                    return CalculateCost(p) + CalculateCost(k / p);
            }

            return k;
        }

        
        static void Main(string[] args)
        {

            Console.Write("Enter a positive integer: ");

            int n = Console.ReadLine().ToInteger();
            
            primes = ACM.GeneratePrimes(n);

            int cost = CalculateCost(n);

            Console.WriteLine("Cost: {0}", cost);
        }
    }
}
