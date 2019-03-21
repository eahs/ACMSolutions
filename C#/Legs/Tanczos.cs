using System;
using ACMHelper;

namespace Legs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of legs: ");
            int legs = Console.ReadLine().ToInteger();
            int solutions = 0;

            // Just making this solution simple.. not worrying about efficiency
            for (int people = 0; people < legs; people++)
            {
                for (int spiders = 0; spiders < legs; spiders++)
                {
                    for (int cockroaches = 0; cockroaches < legs; cockroaches++)
                    {
                        int soln = people * 2 + spiders * 8 + cockroaches * 6;

                        if (soln == legs)
                        {
                            solutions++;
                        }
                    }
                }

            }

            Console.WriteLine("{0} possible combinations of people, spiders, and cockroaches.", solutions);
        }
    }
}
