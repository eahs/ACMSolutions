using System;
using System.Text.RegularExpressions;
using ACMHelper;

namespace SLATIPAC
{
    class Ansari
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            Console.WriteLine("Output: " + Regex.Replace(Console.ReadLine(), "[A-Z]+", n => n.Value.Reverse()));
        }
    }
}
