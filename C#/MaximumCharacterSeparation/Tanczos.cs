using System;

namespace MaximumCharacterSeparation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Word: ");
            string input = Console.ReadLine();

            int max = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int first = input.IndexOf(input[i]);
                int last = input.LastIndexOf(input[i]);

                int diff = last - first;
                if (diff > max)
                    max = diff;
            }

            Console.WriteLine("Maximum character separation: {0}", max);
        }
    }
}
