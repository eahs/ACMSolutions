using System;
using ACMHelper;
using System.Collections.Generic;

namespace AntChess
{
    class Spaziani
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Starting Configuration: ");
                string s = Console.ReadLine();

                List<string> input = new List<string>();
                foreach (char c in s)
                    input.Add(c.ToString());

                int U = Convert.ToInt32(input[0]);
                int UMax = 8;
                int D = Convert.ToInt32(input[1]);
                int DMin = 1;
                string First = input[2];

                int moves = 0;

                while (U != UMax || D != DMin)
                {
                    moves++;
                    if (First == "u")
                    {
                        U++;
                        if (U == UMax)
                        {
                            First = "UP";
                            break;
                        }
                        D--;
                        if (D == DMin)
                        {
                            First = "DOWN";
                            break;
                        }
                    }
                    else
                    {
                        D--;
                        if (D == DMin)
                        {
                            First = "DOWN";
                            break;
                        }
                        U++;
                        if (U == UMax)
                        {
                            First = "UP";
                            break;
                        }
                    }
                }
                Console.WriteLine("The {0} ant wins after {1} move(s)", First, moves);
            }
        }
    }
}
