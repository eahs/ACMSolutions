package com.company;

import java.nio.file.FileSystemNotFoundException;
import java.util.Scanner;

public class SpeedingTicketDobrowolski {
    public static void  main (String[] args)
    {
        Scanner scan = new Scanner(System.in);

        System.out.print("Enter the MPH over the limit: ");
        int mph = scan.nextInt();
        System.out.print("Enter The Base Fee: ");
        int fee = scan.nextInt();

        int total = 0;

        if (mph > 15)
        {
            int quad = mph - 15;
            mph = 15;
            total += quad * (fee * 4);
        }

        if (mph > 5)
        {
            int doub = mph - 5;
            mph = 5;
            total += doub * (fee * 2);
        }

        total += mph * fee;

        System.out.println("Total Cost: " + total);


    }
}
