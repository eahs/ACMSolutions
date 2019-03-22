using System;
using System.Collections.Generic;
using System.Linq;
using ACMHelper;

namespace AntisocialSeating
{
    class Program
    {
        public static List<string> solutions = new List<string>();

        // Translates an integer array into a string
        public static void addSolution (List<int> chairs)
        {
            string map = " ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string layout = "";

            foreach (int k in chairs)
            {
                layout += map[k];
            }

            if (!solutions.Contains(layout))
                solutions.Add(layout);
        }

        // Checks to see if a particular chair is empty
        public static bool isEmpty (List<int> chairs, int index)
        {
            if (index < 0 || index >= chairs.Count) return true;
            return chairs[index] == 0;
        }

        // Counts number of people you would be sitting next to if you sat in seat index
        public static int adjacencyCount (List<int> chairs, int index)
        {
            int sum = 0;
            if (!isEmpty(chairs, index + 1)) sum++;
            if (!isEmpty(chairs, index - 1)) sum++;

            return sum;
        }

        // Gets the list of chairs that have the lowest adjacency counts
        public static List<int> getBest (List<int> chairs)
        {
            // Person will choose onoccupied chairs
            int minAdjacency = Int32.MaxValue;
            List<int> best = new List<int>();
            
            for (int i = 0; i < chairs.Count; i++)
            {
                if (chairs[i] != 0) continue;

                int count = adjacencyCount(chairs, i);
                if (count < minAdjacency)
                {
                    best.Clear();
                    best.Add(i);
                    minAdjacency = count;
                }
                else if (count == minAdjacency)
                {
                    best.Add(i);
                }
            }

            return best;
        }

        // Allows a given person n to try out each of the remaining best seats
        public static void Sitdown (int n, List<int> chairs)
        {
            if (n == chairs.Count)
            {
                chairs[chairs.IndexOf(0)] = n;
                addSolution(chairs);
            }

            List<int> best = getBest(chairs);
            for (int i = 0; i < best.Count; i++)
            {
                int bestIndex = best[i];
                chairs[bestIndex] = n;
                Sitdown(n + 1, new List<int>(chairs));
                chairs[bestIndex] = 0;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Number of chairs: ");
            int n = Console.ReadLine().ToInteger();

            Console.Write("Index: ");
            int index = Console.ReadLine().ToInteger();

            int[] chairs = new int[n];
            Sitdown(1, chairs.ToList());

            solutions.Sort();

            Console.Write("Arrangement of index {0}: {1}", index, solutions[index-1]);

        }
    }
}
