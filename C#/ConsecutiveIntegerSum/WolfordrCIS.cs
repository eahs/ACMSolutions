using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wolfordrCIS
{
    class Program
    {
        public static long solve (int start, int end)
        {
            long solution = 0;
            for (int i = start; i <= end; i++)
            {
                solution += i;
            }

            return solution;
        }

        static void Main(string[] args)
        {
            int[] solutions = new int[1000000];

            for (int i = 1; i < 10000; i++)
            {
                for (int k = i + 1; k < i+100; k++)
                {
                    long soln = solve(i, k);

                    if (soln < solutions.Length)
                        solutions[soln]++;
                }
            }
            //Console.WriteLine(solutions[45]);

        
            Console.Write("Enter a positive integer: ");
            int input = Int32.Parse(Console.ReadLine());

            List<int> answers = solutions.ToList();
            Console.Write("Output: {0}", answers.IndexOf(input));
        }
    }
}
