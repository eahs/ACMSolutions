using System;
using System.Collections.Generic;
using System.Linq;

namespace CarryCount
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter two positive integers to be added: ");
            List<String> nums = Console.ReadLine().Split(" ").ToList();

            int len = Math.Max(nums[0].Length, nums[1].Length);
            nums = nums.Select(n => n.PadLeft(len, '0')).ToList();

            int carry = 0, carries = 0;
            for (int i = nums[0].Length-1; i >= 0; i--)
            {
                String a = nums[0], b = nums[1];

                carry += Convert.ToInt32(a[i] + "") + Convert.ToInt32(b[i] + "");

                if (carry > 9)
                {
                    carries++;
                    carry -= 10;
                }
                else
                    carry = 0;
            }

            Console.WriteLine("There will be {0} {1}.", carries, carries == 1 ? "carry" : "carries");
        }
    }
}
