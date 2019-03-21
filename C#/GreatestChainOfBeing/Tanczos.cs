using System;
using System.Collections.Generic;
using System.Linq;

namespace GreatestChainOfBeing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Size of List: ");
            Console.ReadLine();  // This is for noobs.. who cares

            Console.Write("Numbers in list: ");
            List<string> nums = Console.ReadLine().Split(' ').ToList();

            nums.Sort();
            nums.Reverse();

            Console.Write(String.Join("", nums));


        }
    }
}
