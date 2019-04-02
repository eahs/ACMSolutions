using System;
using ACMHelper;
using System.Collections.Generic;

namespace SpiralNumbering
{
    class Spaziani
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter dimentions of the grid: ");
                List<int> Dim = Console.ReadLine().ToIntegerList();

                int[,] grid = new int[Dim[0], Dim[1]];

                Console.Write("Enter a number within the grid: ");
                int num = Console.ReadLine().ToInteger();

                int count = 1;
                int X = 1, Y = 1;
                int sub = 0;

                double n = 0;
                int a = (grid.GetLength(0) * grid.GetLength(1));

                while (count < a)
                {
                    //Down
                    for (int i = 1; i < grid.GetLength(0) - sub; i++)
                    {
                        Y++;
                        count++;
                        if (count == num)
                            break;
                    }
                    if (count == num)
                        break;
                    n++;
                    for (double j = 3; j < a; j+= 2)
                    {
                        if (n / j == 1)
                            sub++;
                    }
                    //Right
                    for (int i = 1; i < grid.GetLength(1) - sub; i++)
                    {
                        X++;
                        count++;
                        if (count == num)
                            break;
                    }
                    if (count == num)
                        break;
                    n++;
                    for (double j = 3; j < a; j += 2)
                    {
                        if (n / j == 1)
                            sub++;
                    }
                    //Up
                    for (int i = 1; i < grid.GetLength(0) - sub; i++)
                    {
                        Y--;
                        count++;
                        if (count == num)
                            break;
                    }
                    if (count == num)
                        break;
                    n++;
                    for (double j = 3; j < a; j += 2)
                    {
                        if (n / j == 1)
                            sub++;
                    }
                    //Left
                    for (int i = 1; i < grid.GetLength(1) - sub; i++)
                    {
                        X--;
                        count++;
                        if (count == num)
                            break;
                    }
                    if (count == num)
                        break;
                    n++;
                    for (double j = 3; j < a; j += 2)
                    {
                        if (n / j == 1)
                            sub++;
                    }
                }
                Console.WriteLine("{0} is at position({1}, {2}).", num, Y, X);
            }
        }
    }
}
