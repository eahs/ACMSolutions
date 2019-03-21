using System;

namespace ACM
{
    class Quokka
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int Even = 0;
                int E = 0;
                int Odd = 0;
                int O = 0;

                Console.Write("Dice: ");
                string[] nums = Console.ReadLine().Split(' ');

                foreach (string n in nums)
                {
                    int a = Convert.ToInt32(n);
                    if (a % 2 == 0)
                    {
                        Even += a;
                        E++;
                    }
                    else
                    {
                        Odd += a;
                        O++;
                    }
                }
                int Ans = (Even * E) + (Odd * O);
                Console.WriteLine("Profit: $" + Ans);
            }
        }
    }
}
