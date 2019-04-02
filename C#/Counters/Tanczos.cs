using System;
using System.Collections.Generic;
using System.Linq;
using ACMHelper;

namespace Counters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Final counter values: ");
            List<int> values = Console.ReadLine().ToIntegerList();

            int max = values.Select(n => (int)Math.Abs(n)).Max();

            for (int a = 0; a < max; a++)
            {
                for (int b = 0; b < max; b++)
                {
                    for (int c = 0; c < max; c++)
                    {
                        if (a - (b+c) == values[0] &&
                            b - (a+c) == values[1] &&
                            c - (a+b) == values[2])
                        {
                            Console.WriteLine("Counter hits: {0} {1} {2}", a, b, c);
                        }
                    }
                }

            }
        }
    }
}
