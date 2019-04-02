package com.company.Defelice_And_Dobrowolski;

import sun.swing.StringUIClientPropertyKey;

import java.util.Scanner;

public class QuokkaDobrowolski {
    public static void main(String[] args)
    {
        Scanner scan = new Scanner(System.in);

        System.out.print("Dice: ");
        String input = scan.nextLine();

        String[] dice = input.split(" ");

        int oddSum = 0;
        int evenSum = 0;
        int oddCount = 0;
        int evenCount = 0;

        int test = dice.length;

        for (int i = 0; i < dice.length; i++)
        {
            int num = Integer.parseInt(dice[i]);
            if (num % 2 == 0)
            {
                evenSum += num;
                evenCount++;
            }
            else
            {
                oddSum += num;
                oddCount++;
            }
        }

        int oddProfit = oddCount * oddSum;
        int evenProfit = evenCount * evenSum;

        int totalProfit = oddProfit + evenProfit;

        System.out.println("Profit: " + totalProfit);
    }
}
