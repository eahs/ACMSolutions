using System;
using System.Collections.Generic;
using System.Linq;
using ACMHelper;

namespace Quagga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter dice numbers: ");

            List<int> nums = Console.ReadLine().ToIntegerList();

            bool quagga = ((nums[0] + nums[1] * 10) % nums[2] == 0) ||
                          ((nums[1] + nums[2] * 10) % nums[0] == 0) ||
                          ((nums[0] + nums[2] * 10) % nums[1] == 0) ||
                          ((nums[1] + nums[0] * 10) % nums[2] == 0) ||
                          ((nums[2] + nums[1] * 10) % nums[0] == 0) ||
                          ((nums[2] + nums[0] * 10) % nums[1] == 0);

            quagga = quagga && !(nums.Contains(1));

            if (quagga)
                Console.Write("That's a QUAGGA!");
            else
                Console.Write("Sorry, no QUAGGA.");

        }
    }
}
