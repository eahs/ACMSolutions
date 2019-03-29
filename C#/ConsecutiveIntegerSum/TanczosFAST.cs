using System;
using System.Collections.Generic;
using ACMHelper;

namespace ConsecutiveIntegerSums
{
    class Program
    {
        public static List<int> sums = new List<int>();
        public static Dictionary<int,int> hash = new Dictionary<int,int>();

        public static void GenerateSums (int num)
        {
            int sum = 0;

            for (int i = 0; i <= num; i++)
            {
                sum += i;
                sums.Add(sum);
                hash.Add(sum, i);
            }

        }

        public static int CountSums (int num)
        {
            int count = 0;

            for (int i = 1; i < num; i++)
            {
                if (hash.ContainsKey(sums[i] - num))
                    count++;
            }

            return count;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            int num = Console.ReadLine().ToInteger();
            int k = 1;

            GenerateSums(100000);

            while (true)
            {
                if (CountSums(k) == num) break;

                k++;
            }
            
            Console.WriteLine("Output: {0}", k);
        }
    }
}
