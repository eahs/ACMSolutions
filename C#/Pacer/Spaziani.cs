using System;
using System.Collections.Generic;
using ACMHelper;

namespace ACM
{
    class Spaziani
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double mile = 1609;

                Console.Write("Interval distance in meters: ");
                double distance = Convert.ToInt32(Console.ReadLine());

                Console.Write("Target mile pace: ");
                string[] Time = Console.ReadLine().Split(':');

                int min = Convert.ToInt32(Time[0]);
                int sec = Convert.ToInt32(Time[1]);
                double Total = (min * 60) + sec;

                double speed = Total / (mile / distance);
                min = (int)speed / 60;
                sec = (int)speed % 60;

                string s = "";
                if (sec < 10)
                    s = "0" + sec;
                else
                    s = sec.ToString();

                Console.WriteLine("Time for each interval: {0}:{1}", min, s);
            }
        }
    }
}
