package com.company;
import java.util.*;

public class Quagga {
    public static void main (String[] args)
    {
        Scanner scan = new Scanner(System.in);

        System.out.println("Enter Dice numbers: ");

        int[] dice = ACM.toIntegerArray(scan.nextLine());

        boolean isQuagga;

        if(     ((dice[0] * 10 + dice[1]) % dice[2] == 0) ||
                ((dice[0] * 10 + dice[2]) % dice[1] == 0) ||
                ((dice[1] * 10 + dice[0]) % dice[2] == 0) ||
                ((dice[1] * 10 + dice[2]) % dice[0] == 0) ||
                ((dice[2] * 10 + dice[0]) % dice[1] == 0) ||
                ((dice[2] * 10 + dice[1]) % dice[0] == 0)
        )
        {
            isQuagga = true;
        }
        else
        {
            isQuagga = false;
        }

        for(int i = 0; i < dice.length; i++)
        {
            if (dice[i] == 1)
            {
                isQuagga = false;
            }

        }

        if(isQuagga == true)
        {
            System.out.println("That's a QUAGGA!");
        }
        else
        {
            System.out.println("Sorry, no QUAGGA.");
        }
    }
}
