package com.company.Defelice_And_Dobrowolski;

import java.util.Scanner;

public class LineOfSightDobrowolski {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        System.out.print("Enter a positive integer: ");
        int input = scan.nextInt();

        int answer = L(input);

        System.out.println("Points of L(" + input + ") visible from the origin: " + answer);

    }
    private static int L(int n) {
        int count = 2;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (ACM.greatestCommonDivisor(i,j) == 1)
                {
                    count++;
                }
            }
        }
        return count;
    }
}

