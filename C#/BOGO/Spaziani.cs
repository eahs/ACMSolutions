using System;
using System.Collections.Generic;
using System.Text;

namespace ACM
{
    class BOGO
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int S = 2;
                int sml = 0;
                int M = 3;
                int med = 0;
                int L = 5;
                int lrg = 0;

                Console.Write("Enter purchase: ");
                string purchase = Console.ReadLine();

                for (int i = 0; i < purchase.Length; i++)
                {
                    if (purchase[i] == 'S')
                        sml++;
                    else if (purchase[i] == 'M')
                        med++;
                    else
                        lrg++;
                }

                int Ans = (S * sml) + (M * med) + (L * lrg);

                if (sml == 2)
                    Ans -= S;
                else if (med == 2)
                    Ans -= M;
                else if (lrg == 2)
                    Ans -= L;
                Console.WriteLine("Price: $" + Ans);
            }
        }
    }
}

