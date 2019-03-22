using System;
using ACMHelper;
using System.Collections.Generic;

namespace ACM
{
    class Spaziani
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter three coordinates: ");
                string num = Console.ReadLine();
                List<int> nums = num.ToIntegerList();

                nums.Sort();
                List<int> NewNums = num.ToIntegerList();

                int Ans = 0;
                for (int i = 0; i < 3; i++)
                {
                    Ans += nums[i] * NewNums[i];
                }

                Console.WriteLine("Dot Twist: " + Ans);
            }
        }
    }
}
