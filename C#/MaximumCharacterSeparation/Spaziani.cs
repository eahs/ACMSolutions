using System;

namespace MaximumCharacterSeparation
{
    class Spaziani
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Write("Word: ");
                string word = Console.ReadLine();

                int max = -1;

                foreach (char c in word)
                {
                    if (word.LastIndexOf(c) - word.IndexOf(c) > max)
                        max = word.LastIndexOf(c) - word.IndexOf(c);
                }
                Console.WriteLine("Maximum Character Separation: {0}", max);
            }
        }
    }
}
