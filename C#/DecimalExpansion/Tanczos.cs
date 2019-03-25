using System;
using System.Collections.Generic;
using System.Linq;
using ACMHelper;

namespace DecimalExpansion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> decimals = new List<int>();

            Console.Write("Enter a positive integer: ");
            int n = Console.ReadLine().ToInteger();
            int remainder = 1, index;
            bool canbreak = false;

            while (true)
            {
                remainder *= 10;

                if (remainder >= n) canbreak = true;

                int digit = remainder / n;

                index = decimals.IndexOf(digit);

                if (index != -1 && canbreak) break;  // We are starting to repeat digits

                decimals.Add(remainder / n);
                remainder %= n;
            }

            string result = String.Join("", decimals);

            if (index != -1)
                result = result.Substring(0, index) + "[" + result.Substring(index) + "]";

            Console.WriteLine("1/{0} = 0.{1}", n, result);
        }
    }
}
