using System;
using System.Collections.Generic;

namespace Quokka
{
    class Reyes
    {
        static void Main(string[] args)
        {
            int[] rolls = new int[3];
            Console.WriteLine("roll 1: ");
            rolls[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("roll 2: ");
            rolls[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("roll 3: ");
            rolls[2] = Convert.ToInt32(Console.ReadLine());
            int odd = 0;
            int odd2 = 0;
            int even = 0;
            int even2 = 0;
            foreach(int num in rolls)
            {
                if(num % 2 == 0)
                {
                    even++;
                    even2 = even2 + num;

                }
                if(num % 2 != 0)
                {
                    odd++;
                    odd2 = odd2 + num;
                }

            }
            Console.WriteLine((even2*even) + (odd2*odd));

        }
    }
}
