using System;

namespace ACM
{
    class Okapi
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int count = 0;
                int ans = 0;

                Console.Write("Enter dice rolls: ");
                string[] rolls = Console.ReadLine().Split(' ');

                for (int i = 0; i < 2; i++)
                {
                    for (int j = i + 1; j < 3; j++)
                    {
                        if (rolls[i] == rolls[j])
                        {
                            count++;
                        }
                    }
                }
                if (count == 3)
                    ans = Convert.ToInt32(rolls[0]) * 3;
                else if (count == 1)
                {
                    if (rolls[0] == rolls[1])
                        ans = Convert.ToInt32(rolls[0]) + Convert.ToInt32(rolls[1]);
                    else if (rolls[0] == rolls[2])
                        ans = Convert.ToInt32(rolls[0]) + Convert.ToInt32(rolls[2]);
                    else
                        ans = Convert.ToInt32(rolls[1]) + Convert.ToInt32(rolls[2]);
                }
                Console.WriteLine("The payout is: $" + ans);
            }
        }
    }
}
