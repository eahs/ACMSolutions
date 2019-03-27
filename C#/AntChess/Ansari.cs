using System;

namespace AntChess
{
    class Ansari
    {
        static void Main(string[] args)
        {
            Console.Write("Input starting configuration: ");
            String input = Console.ReadLine();
            int upant = (int)Char.GetNumericValue(input[0]);
            int downant = (int)Char.GetNumericValue(input[1]);
            char first = input[2];
            if(8-upant < downant-1)
            {
                Console.WriteLine("The UP ant wins after " + (8 - upant) + " move(s).");
            }
            else if (8 - upant > downant - 1)
            {
                Console.WriteLine("The DOWN ant wins after " + (downant - 1) + " move(s).");
            }
            else if (8 - upant == downant - 1)
            {
                if (first == 'u')
                {
                    Console.WriteLine("The UP ant wins after " + (8 - upant) + " move(s).");
                }
                if (first == 'd')
                {
                    Console.WriteLine("The DOWN ant wins after " + (downant - 1) + " move(s).");
                }
            }
        }
    }
}
