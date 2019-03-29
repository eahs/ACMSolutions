using System;
using System.Collections.Generic;
using ACMHelper;

namespace ConsecutiveIntegerSums
{
    class Program
    {
        public static int CountSums (int num)
        {
            int count = 0;

            for (int i = 1; i < num; i++)
            {
                int sum = 0;
                for (int k = i; k < num; k++)
                {
                    sum += k;

                    if (sum == num)
                    {
                        count++;
                        break;
                    }
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            int num = Console.ReadLine().ToInteger();
            int k = 1;

            while (true)
            {
                if (CountSums(k) == num) break;

                k++;
            }
            
            Console.WriteLine("Output: {0}", k);
        }
    }
}
