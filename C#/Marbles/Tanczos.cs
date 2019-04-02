using System;
using System.Collections.Generic;
using System.Linq;
using ACMHelper;

namespace Marbles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Numerator and Denominator: ");
            List<int> fraction = Console.ReadLine().ToIntegerList();

            int gcd = ACM.GreatestCommonDivisor(fraction[0], fraction[1]);
            fraction[0] /= gcd;
            fraction[1] /= gcd;

            for (int k = 2; k < 1000; k++)
            {
                for (int n = k; n < 1000; n++)
                {
                    int num = k * k - k;
                    int denom = n * n - n;
                    gcd = ACM.GreatestCommonDivisor(num, denom);

                    num /= gcd;
                    denom /= gcd;

                    if (num == fraction[0] && denom == fraction[1])
                    {
                        Console.WriteLine("{0} black and {1} white", k, n - k);
                        break;
                    }
                }
            }
        }
    }
}
