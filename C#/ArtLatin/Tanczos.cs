using System;
using System.Collections.Generic;

namespace ArtLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter sentence: ");
            string input = Console.ReadLine();

            string[] words = input.Split(" ");

            List<string> list = new List<string>();

            foreach (string word in words)
            {
                string output = word;

                if ("AEIOU".Contains(word[0]))
                {
                    if ("AEIOUY".Contains(word[word.Length - 1]))
                    {
                        output += "KART";
                    }
                    else
                    {
                        output += "ART";
                    }
                }
                else
                {
                    if (output.StartsWith("QU"))
                        output = output.Substring(2) + "QUART";
                    else
                        output = output.Substring(1) + output[0] + "ART";
                }

                list.Add(output);
            }

            Console.WriteLine("Translation: {0}", String.Join(' ', list));
        }
    }
}
