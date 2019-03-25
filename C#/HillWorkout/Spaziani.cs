using System;
using ACMHelper;
using System.Collections.Generic;

namespace HillWorkout
{
    class Spaziani
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter x, y, and n: ");
                List<int> workout = Console.ReadLine().ToIntegerList();

                int miles = 0;
                int height = 0;

                while (height < workout[2])
                {
                    miles += workout[0];
                    height += workout[0];
                    if (height >= workout[2])
                        break;
                    miles += workout[1];
                    height -= workout[1];
                    if (height >= workout[2])
                        break;
                }

                miles -= height - workout[2];

                Console.WriteLine("Workout distance: {0} miles.", miles);
            }
        }
    }
}
