using System;
using System.Collections.Generic;
using ACMHelper;

namespace ReplacingTiles
{
    class Program
    {
        public static int solve(int length, int n)
        {
            if (n < length || length > n) return 0;

            int sum = 0;
            for (int i = 0; i <= n - length; i++)
            {
                sum = sum + 1 + solve(length, n - (i+length));
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Number of square white tiles: ");
            int n = Console.ReadLine().ToInteger();

            Console.Write("Length of black tiles: ");
            int length = Console.ReadLine().ToInteger();

            Console.WriteLine("There are {0} replacement configurations.", solve(length, n));
        }
    }
}
