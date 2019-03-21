using System;
using System.Linq;

namespace GlarksFlerbs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int res = Enumerable.Range(1, (int)Math.Pow(2, n))
                                .Select(p => Convert.ToString(p, 2).PadLeft(n, '0'))
                                .Where(p => !p.Contains("00"))
                                .Count();


            
        }
    }
}
