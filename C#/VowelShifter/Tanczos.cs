using System;


namespace VowelShifter
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "aeiouAEIOU";
            string shifted = "eiouaEIOUA";

            Console.WriteLine("Enter a sentence.");

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                int index = original.IndexOf(input[i]);

                if (index != -1)
                    Console.Write(shifted[index]);
                else
                    Console.Write(input[i]);
            }


        }
    }
}
