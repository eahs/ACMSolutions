using System;
using ACMHelper;
using System.Collections.Generic;

namespace Intervals
{
    class Spaziani
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Clock time: ");
                List<int> time1 = Console.ReadLine().ToIntegerList();
                Console.Write("Clock time: ");
                List<int> time2 = Console.ReadLine().ToIntegerList();

                TimeSpan a = new TimeSpan(time1[0],time1[1],time1[2]);
                TimeSpan b = new TimeSpan(time2[0],time2[1],time2[2]);
                TimeSpan diff = a.Subtract(b);
                string H = Math.Abs(diff.Hours).ToString().PadLeft(2,'0');
                string M = Math.Abs(diff.Minutes).ToString().PadLeft(2,'0');
                string S = Math.Abs(diff.Seconds).ToString().PadLeft(2,'0');

                Console.WriteLine("Interval: {0}:{1}:{2}",H,M,S);
            }
        }
    }
}
