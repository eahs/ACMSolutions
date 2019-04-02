using System;
using ACMHelper;
using System.Collections.Generic;

namespace Marbles
{
    class Spaziani
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Numerator and denominator: ");
                List<int> Frac = Console.ReadLine().ToIntegerList();

                double ans = Math.Round(((double)Frac[0] / (double)Frac[1]),10);

                double i = 2;
                double j = 1;
                double A = 0;
                while (A != ans)
                {
                    A = Math.Round((j / i) * ((j - 1) / (i - 1)),10);
                    if (j >= i)
                    {
                        j = 1;
                        i++;
                    }
                    j++;
                }

                Console.WriteLine("{0} black and {1} white", j-1, i - (j-1));
            }
        }
    }
}
