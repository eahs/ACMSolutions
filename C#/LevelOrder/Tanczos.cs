using System;
using System.Collections.Generic;
using System.Linq;
using ACMHelper;

namespace LevelOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter keys (0 to quit): ");
            List<int> nums = Console.ReadLine().ToIntegerList();

            int[] tree = new int[1000];

            foreach (int n in nums)
            {
                int index = 0;

                while (tree[index] != 0)
                {
                    if (n > tree[index])
                        index = 2 * index + 2; // Right child node
                    else if (n < tree[index])
                        index = 2 * index + 1; // Left child node
                    else
                        break;
                }

                tree[index] = n;
            }

            var nodes = tree.ToList().Where(n => n != 0);

            Console.WriteLine("The keys in level order are: {0}", String.Join(' ', nodes));
           
            
        }
    }
}
