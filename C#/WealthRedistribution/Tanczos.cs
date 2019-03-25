using System;
using System.Collections.Generic;
using System.Linq;

namespace WealthRedistribution
{
    class Program
    {
        static int maxIndex (List<int> nums)
        {
            int index = nums.Count - 1;

            for (int i = nums.Count-1; i >= 0; i--)
            {
                if (nums[i] > nums[index])
                    index = i;
            }
            
            return index;
        }

        static int minIndex(List<int> nums)
        {
            int index = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] < nums[index])
                    index = i;
            }
           
            return index;
        }

        static void Main(string[] args)
        {
            int n = 15;
            int count = 0;
            bool redistribute = true;
            List<int> nums = Enumerable.Range(n/2, n).ToList();

            do
            {
                int min = minIndex(nums);
                int max = maxIndex(nums);

                redistribute = Math.Abs(nums[min] - nums[max]) > 1;

                if (redistribute)
                {
                    count++;
                    nums[min]++;
                    nums[max]--;
                }

            } while (redistribute);

            Console.WriteLine(count);
        }
    }
}
