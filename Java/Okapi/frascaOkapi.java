package com.company;
import java.util.*;

public class frascaOkapi {
    public static void main(String[] args){

        int sum;

        Scanner scan = new Scanner(System.in);

        System.out.println("Enter Dice numbers: ");

        int[] dice = ACM.toIntegerArray(scan.nextLine());

        if (dice[0] == dice[1] && dice[1] == dice[2])
        {
          sum = dice[0] + dice[1] + dice[2];
        }
        else if (dice[0] == dice[1])
        {
            sum = dice[0] + dice[1];
        }
        else if(dice[0] == dice[2])
        {
            sum = dice[0] + dice[2];
        }
        else if(dice[1] == dice[2])
        {
            sum = dice[1] + dice[2];
        }
        else
        {
            sum = 0;
        }

        System.out.println("The payout is: " + sum);
    }
}
