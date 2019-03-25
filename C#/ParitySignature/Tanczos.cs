using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using ACMHelper;

namespace ParitySignature
{
    class Program
    {
        public static string signature (int n)
        {
            string result = "";

            // Turn the string into a sequence of a's (even) and b's (odd)
            List<string> sequence = n.ToString().Select(p => Convert.ToInt32(p + "") % 2 == 0 ? "a" : "b").ToList();
            result = String.Join("", sequence);

            // This reduces sequences of a's or b's by replacing them with the number of a's or b's
            result = Regex.Replace(result, "[a]+", m => m.Value.Length.ToString() + " ");
            result = Regex.Replace(result, "[b]+", m => m.Value.Length.ToString() + " ");

            // This note at the end says that signatures must begin with the count of even numbers, so if the first is odd we add a "0"
            if (sequence[0] == "b") result = "0 " + result;

            return result.Trim();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter two positive integers: ");
            List<int> nums = Console.ReadLine().ToIntegerList();

            int product = nums[0] * nums[1];

            Console.WriteLine("Parity signature of product {0} = {1}", product, signature(product));
        }
    }
}
