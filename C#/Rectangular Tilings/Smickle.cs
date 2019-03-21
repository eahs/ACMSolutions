using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter width and height of grid: ");
            List<String> nums = Console.ReadLine().Split(' ').ToList();
            int width = Convert.ToInt32(nums[0]);
            int height = Convert.ToInt32(nums[1]);
            int total = 0;

            for(int i = 1; i <= width; i++)
            {
                for(int j = 1; j <= height; j++)
                {
                    total = total + (i * j);
                }
            }

            Console.Write(total + " rectangular tilings.");
        }
    }
}
