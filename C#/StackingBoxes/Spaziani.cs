using System;
using ACMHelper;
using System.Collections.Generic;

namespace StackingBoxes
{
    class Spaziani
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("How many boxes? ");
                int boxes = Console.ReadLine().ToInteger();

                int count = 0;

                List<int> nums = new List<int>();
                int j = 1;
                while (boxes > 0)
                {                  
                    if (j * j > boxes)
                    {
                        count++;
                        nums.Add(j-1);                       
                        boxes -= (j - 1) * (j - 1);
                        j = 1;
                    }
                    j++;
                }

                for (int i = 0; i < count; i++)
                {
                    string n = "";
                    if (i == 0)
                        n = "st";
                    else if (i == 1)
                        n = "nd";
                    else if (i == 2)
                        n = "rd";
                    else n = "th";
                    Console.WriteLine("Height of {0} stack: {1}", i+1 + n, nums[i]);
                }
            }
        }
    }
}
