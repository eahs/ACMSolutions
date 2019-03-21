using System;
using System.Collections.Generic;
using System.Linq;

namespace BackAndForth
{
    class Program
    {
        static void Main(string[] args)
        {
            // This problem can be simplified using modular arithmetic

            Console.Write("Enter A, B, and T: ");
            List<long> nums = Console.ReadLine().Split(' ').Select(n => Convert.ToInt64(n)).ToList();

            long diff = (long)Math.Abs(nums[0] - nums[1]);

            long reduce = nums[2] % diff;
            long trips = nums[2] / diff;

            // If we are coming back from B
            if (trips % 2 == 1)
            {
                if (nums[0] > nums[1])
                    Console.WriteLine((long)Math.Min(nums[0], nums[1]) + reduce);
                else
                    Console.WriteLine((long)Math.Max(nums[0], nums[1]) - reduce);


            }
            else
            {
                if (nums[1] > nums[0])
                    Console.WriteLine((long)Math.Min(nums[0], nums[1]) + reduce);
                else
                    Console.WriteLine((long)Math.Max(nums[0], nums[1]) - reduce);

            }


        }
    }
}
