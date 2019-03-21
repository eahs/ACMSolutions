using System;
using System.Collections.Generic;
using System.Linq;
using ACMHelper;

namespace LongestReversibleRemainder
{
    class Program
    {
        public static List<String> solutions = new List<string>();

        public static void Solve(String prefix, String s)
        {
            bool foundFirst = false;

            for (int i = 0; i < s.Length; i++)
            {
                int last = s.LastIndexOf(s[i]);

                if (i == last || i + 1 == last)
                {
                    if (!foundFirst)
                        solutions.Add(prefix + s[i] + prefix.Reverse());

                    foundFirst = true;
                }
                else if (last != -1)
                    Solve(prefix + s[i], s.Substring(i + 1, last - i - 1));
            }
        }

        static void Main(string[] args)
        {
            //String input = "STAR DESTROYER";
            String input = "SHUT DOWN ALL THE GARBAGE MASHERS ON THE DETENTION LEVEL";

            input = input.Replace(" ", "");

            Solve("", input);

            string longest = solutions.OrderByDescending(n => n.Length).First();

            Console.WriteLine("Longest reversible remainder: {0} {1}", longest, longest.Length);
        }
    }
}
