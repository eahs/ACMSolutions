using System;
using System.Linq;
using System.Collections.Generic;
using ACMHelper;

namespace LineOfSight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            int n = Console.ReadLine().ToInteger();

            List<string> points = new List<string>();
            for (int r = 0; r <= n; r++)
            {
                for (int c = 0; c <= n; c++)
                {
                    if (r == c && c == 0) continue;

                    int gcf = ACM.GreatestCommonDivisor(r, c);
                    
                    string point = (r/gcf) + "," + (c/gcf);   // Reduce every point by it's greatest common divisor (since that point was seen first)
                    if (!points.Contains(point))
                        points.Add(point);
                }
            }

            Console.WriteLine("Points of L({0}) visible from the origin: {1}", n, points.Count);
        }
    }
}
