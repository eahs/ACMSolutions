package com.company.Defelice_And_Dobrowolski;

import java.util.Scanner;

public class OkapiDobrolice {
    public static void main (String[] args)
    {
        //Dobrowolski and Difelice
        Scanner scan = new Scanner(System.in);

        System.out.print("Enter dice rolls: ");
        String input = scan.nextLine();

        String[] array = input.split(" ");

        int roll1 = Integer.parseInt(array[0]);
        int roll2 = Integer.parseInt(array[1]);
        int roll3 = Integer.parseInt(array[2]);

        int result = 0;

        if (roll1 == roll2 && roll1 == roll3)
        {
            result = roll1* 3;
        }
        else if (roll1 == roll2)
        {
            result = roll1 + roll2;
        }
        else if (roll1 == roll3)
        {
            result = roll1 + roll3;
        }
        else if (roll2 == roll3)
        {
            result = roll2 + roll3;
        }

        System.out.println("The payout is $" + result);

    }

}
