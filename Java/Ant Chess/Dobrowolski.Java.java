package com.company;

import java.util.Scanner;

public class AntChessDobrowolski {
    public static void main (String[] args)
    {
        Scanner scan = new Scanner(System.in);

        System.out.print("Input the String: ");
        String input = scan.nextLine();

        String[] parts = input.split("");

        int up = Integer.parseInt(parts[0]);
        int down = Integer.parseInt(parts[1]);
        int count = 0;

        while (up < 8 && down > 1)
        {
            if (parts[2].equals("d"))
            {
                down--;
                up++;
                count++;
            }
            else
            {
                up++;
                down--;
                count++;
            }
        }

        if (up >=8)
        {
            System.out.println("The UP and wins after " + count + " move(s)");
        }
        else
        {
            System.out.println("The DOWN and wins after " + count + " move(s)");
        }

    }
}
