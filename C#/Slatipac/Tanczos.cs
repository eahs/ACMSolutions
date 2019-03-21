using System;
using System.Text.RegularExpressions;
using ACMHelper;

namespace Slatipac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();
            string output = Regex.Replace(input, "[A-Z]+", m => m.Value.Reverse());

            Console.WriteLine("Output: {0}", output);
        }
    }
}
