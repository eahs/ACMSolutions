using System;

namespace Legs
{
    class Spaziani
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Number of legs: ");
                int legs = Convert.ToInt32(Console.ReadLine());

                int count = 0;
                for (int i = 0; i < legs; i ++)
                    for (int j = 0; j < legs; j ++)                   
                        for (int k = 0; k < legs; k ++)                        
                            if ((i * 8) + (j * 6) + (k * 2) == legs)
                                count++;

                Console.WriteLine("{0} possible combinations of people, spiders, and cockroaches.", count);
            }
        }
    }
}
