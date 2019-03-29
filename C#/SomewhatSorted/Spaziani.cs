using System;
using ACMHelper;
using System.Collections.Generic;

namespace SomewhatSorted
{
    class Spaziani
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Length of sequence: ");
                int l = Console.ReadLine().ToInteger();
                Console.Write("Terms of sequence: ");
                List<int> nums = Console.ReadLine().ToIntegerList();

                bool Check = true;

                for (int i = 1; i < l; i++)
                {
                    int Last = nums.LastIndexOf(nums[i]);
                    int OneLess = nums.IndexOf(nums[i] - 1);
                    if (nums[i] == 1)
                        continue;
                    if (Last < OneLess || OneLess == -1)
                    {
                        Check = !Check;
                    }
                }

                Console.WriteLine(Check.ToString().ToUpper());
            }
        }
    }
}
