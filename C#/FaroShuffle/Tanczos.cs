using System;
using System.Collections.Generic;
using System.Linq;
using ACMHelper;

namespace FaroShuffle
{
    class Program
    {
        public static void faroShuffle(List<int> deck)
        {
            int mid = deck.Count / 2;
            List<int> top = deck.Take(mid).ToList();
            List<int> bottom = deck.Skip(mid).Take(mid).ToList();

            deck.Clear();
            for (int i = 0; i < mid; i++)
            {
                deck.Add(bottom[i]);
                deck.Add(top[i]);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Number of cards in the deck: ");
            int n = Console.ReadLine().ToInteger();

            List<int> deck = Enumerable.Range(1, n).ToList();

            int count = 0;
            do
            {
                faroShuffle(deck);
                count++;
            } while (!deck.IsIncreasing());  // ACMHelper list extension method IsIncreasing

            Console.WriteLine("The deck will return to its initial ordering after {0} in-shuffles.", count);
        }
    }
}
