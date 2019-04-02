using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Numerics;
using ACMHelper;

namespace SpiralNumbering
{
    class Program
    {
        public static void draw (int[,] grid, int rows, int columns)
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    Console.Write(grid[r, c].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }
        }

        public static bool isAvailable(int[,] grid, int rows, int columns, Vector2 pos)
        {
            int x = (int)pos.X, y = (int)pos.Y;

            return (x < columns && y < rows && x >= 0 && y >= 0 && grid[y,x] == 0);                
        }

        static void Main(string[] args)
        {
            int direction = 0;
            Vector2[] directions = { new Vector2(0, 1), new Vector2(1, 0), new Vector2(0, -1), new Vector2(-1, 0) };


            Console.Write("Enter dimensions of the grid: ");
            List<int> dimensions = Console.ReadLine().ToIntegerList();

            Console.Write("Enter a number within the grid: ");
            int n = Console.ReadLine().ToInteger();

            int rows = dimensions[0], columns = dimensions[1];
            int[,] grid = new int[rows, columns];

            int count = 1, targetRow = -1, targetColumn = -1;
            Vector2 position = Vector2.Zero;

            while (count <= rows * columns)
            {
                int y = (int)position.Y, x = (int)position.X;

                grid[y, x] = count;

                if (grid[y, x] == n) { targetRow = y; targetColumn = x; break;  }

                Vector2 nextPosition = position + directions[direction % 4];

                if (isAvailable(grid, rows, columns, nextPosition))
                {
                    position = nextPosition;
                }
                else
                {
                    direction++;  // Turn
                    position += directions[direction % 4];  // Go to the next spot
                }

                count++;
            }
            
            //    draw(grid, rows, columns);

            Console.Write("{0} is at position ({1},{2})", n, targetRow+1, targetColumn+1);


        }
    }
}
