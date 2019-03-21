using System;
using System.Collections.Generic;
using System.Numerics;
using ACMHelper;

namespace PrimePowers
{
    class Program
    {
        
        public static string nth(int n)
        {
            string num = n.ToString();

            if (num.EndsWith("1")) return n + "st";
            if (num.EndsWith("2")) return n + "nd";
            if (num.EndsWith("4")) return n + "nd";

            return n + "th";
        }

        static void Main(string[] args)
        {
            List<int> primes = ACM.GeneratePrimes(80000);
            List<BigInteger> powers = new List<BigInteger>();
            Dictionary<string, string> powerNames = new Dictionary<string, string>();
            
            // This problem is the WORST.. too much stuff going on
            // Let's just brute force generate a ton of things
            // and hope for the best
            foreach (int p in primes)
            {
                for (int i = 1; i < 64; i++)
                {
                    BigInteger result = BigInteger.Pow(p, i);
                    powers.Add(result);
                    powerNames.Add(result.ToString(), p + "^" + i);
                }
            }
            powers.Sort();

            Console.Write("Enter a positive integer: ");
            int n = Console.ReadLine().ToInteger();

            string ending = ".";

            string pname = powerNames[powers[n - 1] + ""];

            if (!pname.EndsWith("^1"))
                ending = " = " + pname + ".";

            Console.WriteLine("The " + nth(n) + " prime power is " + powers[n-1] + ending);
        }
    }
}
