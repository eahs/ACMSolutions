using System;
using ACMHelper;
using System.Collections.Generic;
using System.Linq;

namespace consecutiveIntegerSums
{
    class Spaziani
    {

        public static long Solve(int start, int end)
        {
            long Sol = 0;
            for (int i = start; i <= end; i++)
            {
                Sol += i;
            }

            return Sol;
        }

        static void Main(string[] args)
        {
            int[] Ans = new int[1000000];

            for (int i = 1; i < Ans.Length/10; i++)
            {
                for (int j = i + 1; j < i + 100; j++)
                {
                    long a = Solve(i, j);

                    if (a < Ans.Length)
                        Ans[a]++;
                }
            }

            while (true)
            {
                Console.Write("Enter a positive integer: ");
                int input = Console.ReadLine().ToInteger();

                List<int> answers = Ans.ToList();
                Console.WriteLine("Output: {0}", answers.IndexOf(input));
            }
        }
    }
    
}
