using System;
using System.Collections.Generic;
using System.Linq;

namespace StackingBoxes
{
    class Program
    {
        public static int findGreatestFactorIndex (List<int> factors, int n)
        {
            return factors.Where(k => k <= n).Count() - 1 ;
        }

        static void Main(string[] args)
        {
            List<int> factors = new List<int>();
            List<int> heights = new List<int>();
            int stackCount = 0;
            string[] stackNames = { "1st", "2nd", "3rd", "4th" };

            int n = 125;

            for (int height = 1; height < n; height++)
            {
                int span = 1, count = 0;
                for (int i = 0; i < height; i++)
                {
                    count += span;
                    span += 2;
                }

                factors.Add(count);
                heights.Add(height);
            }

            while (n > 0)
            {
                int gfi = findGreatestFactorIndex(factors, n);
                Console.WriteLine("Height of {0} Stack: {1}", stackNames[stackCount], heights[gfi]);
                stackCount++;
                n -= factors[gfi];
            }
        }
    }
}
