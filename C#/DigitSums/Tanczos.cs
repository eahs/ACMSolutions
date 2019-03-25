using System;
using System.Collections.Generic;
using System.Linq;
using ACMHelper;

namespace DigitSums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of digits and sum: ");
            List<int> nums = Console.ReadLine().ToIntegerList();

            int k = nums[0];
            int start = (int)Math.Pow(10, k - 1);
            int end = (int)Math.Pow(10, k) - 1;

            int count = 0;

            for (int i = start; i <= end; i++)
            {
                int sum = i.ToString()
                            .ToCharArray()
                            .Select(p => Convert.ToInt32(p+""))
                            .ToList()
                            .Sum();

                if (sum == nums[1]) count++;
            }

            Console.WriteLine(count);

        }
    }
}
