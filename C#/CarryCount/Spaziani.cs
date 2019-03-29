using System;
using ACMHelper;
using System.Collections.Generic;

namespace CarryCount
{
    class Spaziani
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter two positive integers to be added: ");
                List<int> nums = Console.ReadLine().ToIntegerList();

                int min = Math.Min(nums[0], nums[1]);
                int Max = Math.Max(nums[0], nums[1]);

                int count = 0;

                while (Max > 0)
                {
                    int a = min % 10;
                    int b = Max % 10;

                    Max /= 10;
                    min /= 10;

                    if (a + b >= 10)
                    {
                        count++;
                        Max++;
                        if (b >= 10)
                        {
                            count++;
                            Max /= 10;
                            Max = Convert.ToInt32(Max.ToString().PadRight(Max.ToString().Length, '0'));
                        }
                    }

                }
                Console.WriteLine("There will be {0} carries", count);
            }
        }
    }
}
