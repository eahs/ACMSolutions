using System;
using System.Collections.Generic;
using System.Linq;
using ACMHelper;

namespace BoundedWeightSequences
{
    class Program
    {
        public static int Weight (int num)
        {
            return (int)Math.Ceiling(Math.Log10(num));  // # of digits
        }

        static void Main(string[] args)
        {
            Console.Write("Starting integer: ");
            int n = Console.ReadLine().ToInteger();

            Console.Write("Weight bound: ");
            int bound = Console.ReadLine().ToInteger();

            // Calculate weights for integers 1 to bound*2
            List<int> weights = Enumerable.Range(1, bound * 2).Select(k => Weight(k)).ToList();  

            int end = n - 1, sum = 0;
            
            for (int i = n; i < weights.Count; i++)
            {
                if (sum + weights[i] > bound) break;

                sum += weights[i];
                end++;
            }

            Console.WriteLine("The sequence ({0}-{1}) has weight {2}.", n, end, sum);
        }
    }
}
