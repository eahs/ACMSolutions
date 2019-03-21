using System;

namespace Quokka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dice: ");
            int[] dice = { 0, 0, 0 };
            dice[0] = Convert.ToInt32(Console.ReadLine());
            dice[1] = Convert.ToInt32(Console.ReadLine());
            dice[2] = Convert.ToInt32(Console.ReadLine());
            int even = 0; int odd = 0; int evensum = 0; int oddsum = 0;
            foreach (int num in dice)
            {
                if (num % 2 == 0)
                {
                    even++;
                    evensum += num;
                }
                else
                {
                    odd++;
                    oddsum += num;
                }
            }
            int result = (evensum * even) + (oddsum * odd);
            Console.WriteLine("Result: $" + result);
        }
    }
}
