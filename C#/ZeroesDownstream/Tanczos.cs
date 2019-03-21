using System;
using System.Collections.Generic;
using System.Numerics;
using ACMHelper;

namespace ZeroesDownstream
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BigInteger> powers = new List<BigInteger>();
            
            Console.Write("Enter a positive integer: ");
            BigInteger n = new BigInteger(Console.ReadLine().ToInteger());

            // Every time we hit a power of 5 we add an extra 0
            BigInteger zeroes = 0;
            for (int i = 1; i < 10000; i++)
            {
                BigInteger power = BigInteger.Pow(5, i);

                zeroes += BigInteger.Divide(n, power);

                if (power > n)
                    break;
            }

            Console.Write("h(n) = {0}", zeroes);

        }
    }
}
