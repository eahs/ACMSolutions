package com.company;
import java.util.*;

public class Quokka {

    public static void main(String[] args) {
        int dice1, dice2, dice3;
        int sumEven = 0;
        int numberEven = 0;
        int sumOdd = 0;
        int numberOdd =0;

        Scanner scan = new Scanner(System.in);

        System.out.println("Enter Dice 1 value: ");
        dice1 = scan.nextInt();
        System.out.println("Enter Dice 2 value: ");
        dice2 = scan.nextInt();
        System.out.println("Enter Dice 3 value: ");
        dice3 = scan.nextInt();

        if(dice1 % 2 == 0)
        {
            sumEven = dice1;
            numberEven++;
        }
        else
        {
            sumOdd = dice1;
            numberOdd++;
        }
        if(dice2 % 2 == 0)
        {
            sumEven += dice2;
            numberEven++;
        }
        else
        {
            sumOdd += dice2;
            numberOdd++;
        }
        if(dice3 % 2 == 0)
        {
            sumEven += dice3;
            numberEven++;
        }
        else
        {
            sumOdd += dice3;
            numberOdd++;
        }

        int sum = 0;
        sum = (numberEven * sumEven) + (numberOdd * sumOdd);

        System.out.println("Sum = " + sum);
    }
}
