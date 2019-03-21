using System;
using System.Collections.Generic;
using System.Linq;

namespace SomewhatSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Length of Sequence: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Terms of Sequence: ");
            List<int> nums = Console.ReadLine().Split(" ").Select(n => Convert.ToInt32(n)).ToList();

            bool ok = true;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == 1) continue;

                int lastIndex = nums.LastIndexOf(nums[i]);
                int previousIndex = nums.IndexOf(nums[i] - 1);

                if (lastIndex < previousIndex || previousIndex == -1)
                    ok = false;
            }

            Console.WriteLine(ok.ToString().ToUpper());

        }
    }
}
