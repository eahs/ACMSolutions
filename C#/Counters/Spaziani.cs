using System;
using ACMHelper;
using System.Collections.Generic;

namespace Counters
{
    class Spaziani
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Final counter value: ");
                List<int> nums = Console.ReadLine().ToIntegerList();

                int count1 = 0;
                int count2 = 0;
                int count3 = 0;
                while (nums[0] != 0 || nums[1] != 0 || nums[2] != 0)
                {
                    if (nums[0] == Math.Max(nums[0], Math.Max(nums[1], nums[2])) && (nums[0] != 0 || nums[1] != 0 || nums[2] != 0))
                    {
                        nums[0]--;
                        nums[1]++;
                        nums[2]++;
                        count1++;
                    }
                    if (nums[1] == Math.Max(nums[1], Math.Max(nums[0], nums[2])) && (nums[0] != 0 || nums[1] != 0 || nums[2] != 0))
                    {
                        nums[0]++;
                        nums[1]--;
                        nums[2]++;
                        count2++;
                    }
                    if (nums[2] == Math.Max(nums[2], Math.Max(nums[1], nums[0])) && (nums[0] != 0 || nums[1] != 0 || nums[2] != 0))
                    {
                        nums[0]++;
                        nums[1]++;
                        nums[2]--;
                        count3++;
                    }
                }
                Console.WriteLine("{0} {1} {2}", count1, count2, count3);
            }
        }
    }
}
