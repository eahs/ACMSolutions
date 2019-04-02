using System;
using System.Linq;
using System.Collections.Generic;
using ACMHelper;

namespace SubSub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            String input = Console.ReadLine();

            List<String> subs = input.FindAllSubstrings()
                                     .GroupBy(n => n)  // Group duplicates
                                     .Where(g => g.Count() > 1 && input.Contains(g.Key+g.Key))  // Where there is more than one and they are consecutive
                                     .Select(g => g.Key)  // Keep just the matching string
                                     .OrderByDescending(s => s.Length)  // Order longest string to shortest
                                     .ToList();

            if (subs.Count == 0)
                Console.WriteLine("Output: NO SOLUTION");
            else
                Console.WriteLine("Output: {0}", subs[0]);
        }
    }
}
