using System;
using System.Linq;

namespace enemies
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int Seats = Convert.ToInt32(Console.ReadLine());
                var res = Enumerable.Range(1, (int)Math.Pow(2, Seats)).Select(x => Convert.ToString(x, 2).PadLeft(Seats, '0')).Where(x => !x.Contains("00")).Count();
                Console.WriteLine(res);
            }
        }
    }
}
