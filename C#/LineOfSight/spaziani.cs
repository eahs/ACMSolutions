using System;
using ACMHelper;
using System.Collections.Generic;

namespace LineOfsight
{
    class Spaziani
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a positive integer: ");
                int nums = Convert.ToInt32(Console.ReadLine());
                int count = 2;
                List<double> dec = new List<double>();


                for (int i = 1; i <= nums; i++)
                {
                    for (int j = 1; j <= nums; j++)
                    {
                        if ((i == 1 && j == 1) || i != j)
                        {
                            if (!dec.Contains((double)i/(double)j))
                            {
                                dec.Add((double)i / (double)j);
                                count++;
                            }
                        }                          
                    }
                }
                Console.WriteLine("Points at L({0}) visible from the origin: {1}", nums, count);
            }
        }
    }
}
