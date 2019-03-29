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

        static void Main(string[] args)
        {
            Console.Write("Enter dimensions of the grid: ");
            List<int> dimensions = Console.ReadLine().ToIntegerList();

            Console.Write("Enter a number within the grid: ");
            int n = Console.ReadLine().ToInteger();

            int rows = dimensions[0], columns = dimensions[1];
            int[,] grid = new int[rows, columns];

            int targetRow = -1, targetColumn = -1;

            int diry = -1, dirx = -1, rowtravel = rows, coltravel = columns, row = 0, col = 0;
            int count = 1;

            while (count <= rows*columns)
            {
                diry *= -1;
                for (int r = 0; r < rowtravel; r++)
                {
                    grid[row, col] = count++;
                    if (grid[row,col] == n) { targetRow = row; targetColumn = col; }
                    row += diry;
                }
                col -= dirx;
                row -= diry;

                coltravel--;

                dirx *= -1;
                for (int c = 0; c < coltravel; c++)
                {
                    grid[row, col] = count++;
                    if (grid[row, col] == n) { targetRow = row; targetColumn = col; }
                    col += dirx;
                }
                col -= dirx;
                row -= diry;

                rowtravel--;

                if (targetColumn != targetRow)
                    break;
            }

            //draw(grid, rows, columns);
            Console.Write("{0} is at position ({1},{2})", n, targetRow+1, targetColumn+1);


        }
    }
}
