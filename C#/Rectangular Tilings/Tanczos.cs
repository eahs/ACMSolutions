using System;
using System.Linq;
using System.Collections.Generic;
using ACMHelper;

namespace RectangularTilings
{
    class Program
    {
        public static int sum (int n)
        {
            if (n == 1) return 1;

            return n + sum(n - 1);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter width and height of grid: ");
            List<int> nums = Console.ReadLine().ToIntegerList();

            int soln = sum(nums[0]) * sum(nums[1]);
            Console.WriteLine("{0} rectangular tilings.", soln);
        }
    }
}
