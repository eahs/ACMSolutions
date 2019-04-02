using System;
using System.Linq;
using System.Collections.Generic;
using ACMHelper;

namespace DromedaryWords
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            List<int> vals = word.ToCharArray().Select(n => n - 'A').ToList();  // Turn into a list of integers

            int hump = vals.IndexOf(vals.Max());  // Find the location of the hump
            List<int> secondHalf = vals.GetRange(hump, vals.Count - hump);  // Get everything after the hump
            secondHalf.Reverse();  // Reverse the list so we can just check if it too is IsIncreasing

            if (vals.IsIncreasing(0, hump) && secondHalf.IsIncreasing())
            {
                Console.WriteLine("{0} is a dromedary word.", word);
            }
            else
            {
                Console.WriteLine("{0} is NOT a dromedary word.", word);
            }
        }
    }
}
