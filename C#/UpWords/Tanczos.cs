using System;
using System.Collections.Generic;

namespace UpWords
{
    class Program
    {
        public static List<string> upwords = new List<string>();

        public static void generateUpwords(char bound, string prefix, int len)
        {
            char start = 'A';
            if (prefix.Length > 0)
                start = (char)(prefix[prefix.Length - 1] + 1);

            for (char c = start; c <= bound; c++)
            {
                string word = prefix + c;

                if (word.Length == len)
                    upwords.Add(word);
                else
                    generateUpwords(bound, prefix + c, len);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Size: ");
            int len = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bound: ");
            string bound = Console.ReadLine();

            Console.Write("Index: ");
            int index = Convert.ToInt32(Console.ReadLine());

            generateUpwords(bound[0], "", len);

            Console.WriteLine("Upword: {0}", upwords[index-1]);
        }
    }
}
