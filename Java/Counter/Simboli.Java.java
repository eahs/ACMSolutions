package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class Main
{

    public static void main(String[] args)
    {
        Scanner keyboard = new Scanner(System.in);

        System.out.print("Final counter values: ");

        int counter1 = keyboard.nextInt();
        int counter2 = keyboard.nextInt();
        int counter3 = keyboard.nextInt();

        int[] counter = {counter1, counter2, counter3};
        printHits(counter);
    }

    private static void printHits(int[] counter)
    {
        for (int a = 0; a < 10; a++)
        {
            for (int b = 0; b < 10; b++)
            {
                for (int c = 0; c < 10; c++)
                {
                    int[] hits = {a, b, c};
                    if (Arrays.equals(calculate(hits), counter))
                    {
                        System.out.println("Counter hits: " + hits[0] + " " + hits[1] + " " + hits[2]);
                        return;
                    }
                }
            }
        }

    }

    private static int[] calculate (int[] counter)
    {
        int[] solution = {0, 0, 0};

        for (int i = 0; i < counter[0]; i++)
        {
            solution[0]++;
            solution[1]--;
            solution[2]--;
        }

        for (int i = 0; i < counter[1]; i++)
        {
            solution[1]++;
            solution[0]--;
            solution[2]--;
        }

        for (int i = 0; i < counter[2]; i++)
        {
            solution[2]++;
            solution[1]--;
            solution[0]--;
        }

        return solution;
    }

}
