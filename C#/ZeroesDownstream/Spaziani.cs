using System;
using System.Numerics;

namespace ZerosDownstream
{
    class ZerosDownstream
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter positive integer: ");
                int nums = Convert.ToInt32(Console.ReadLine());

                BigInteger count = 0;
                for (BigInteger i = 1; i < nums; i++)
                {
                    BigInteger power = BigInteger.Pow(5, (int)i);

                    if (power > nums) break;

                    count += nums / power;

                }


                Console.WriteLine("h(n) = " + count);
            }
        }
    }
}
