﻿using System;
using System.Collections.Generic;
using System.Linq;
using ACMHelper;

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
            List<string> results = new List<string>();

            // Credit to Anna DiFelice for finding this algorithm
            nums.Sort((a, b) => (a+b).ToInteger().CompareTo((b+a).ToInteger()));
            nums.Reverse();

            Console.Write(String.Join("", nums.ToArray()));

            /*
            // Tanczos Brute force approach.. 
            var permutations = nums.Permute();

            foreach (var permutation in permutations)
            {
                List<string> p = permutation.ToList();
                results.Add(String.Join("", p.ToArray()));
            }

            results.Sort();
            results.Reverse();
            */


        }
    }
}
