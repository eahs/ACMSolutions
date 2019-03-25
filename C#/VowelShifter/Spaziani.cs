using System;

namespace VowelShifter
{
    class Spaziani
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string norm = "aeiouAEIOU";
                string weird = "eiouaEIOUA";

                Console.WriteLine("Enter a sentence.");
                string input = Console.ReadLine();

                for (int i = 0; i < input.Length; i++)
                {
                    int index = norm.IndexOf(input[i]);

                    if (index != -1)
                        Console.Write(weird[index]);
                    else
                        Console.Write(input[i]);
                }
            }
        }
    }
}
