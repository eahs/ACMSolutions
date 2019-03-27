package com.company.Defelice_And_Dobrowolski;

import java.util.*;

public class IntervalDofeowce {
    public static void main(String[] args)
    {
        Scanner scan = new Scanner(System.in);

        System.out.print("Input clock one Times: ");
        String clock1 = scan.nextLine();

        System.out.print("Input clock two Times: ");
        String clock2 = scan.nextLine();

        String[] times1 = clock1.split(" ");
        String[] times2 = clock2.split(" ");

        int onehour = Integer.parseInt(times1[0]);
        int onemin = Integer.parseInt(times1[1]);
        int onesec = Integer.parseInt(times1[2]);

        int twohour = Integer.parseInt(times2[0]);
        int twomin = Integer.parseInt(times2[1]);
        int twosec = Integer.parseInt(times2[2]);

        int finaltime1 = (onehour * 3600) + (onemin * 60) + onesec;

        int finaltime2 = (twohour * 3600) + (twomin * 60) + twosec;

        int diff = Math.abs(finaltime1 - finaltime2);

        int finalhour = diff / 3600;
        diff = diff % 3600;

        int finalmin = diff / 60;
        diff = diff % 60;

        int finalsec = diff;

        String FINALhour = "" + finalhour;
        String FINALmin = "" + finalmin;
        String FINALsec = "" + finalsec;


        if (finalhour < 10)
        {
            FINALhour = "0" + finalhour;
        }
        if (finalmin < 10)
        {
            FINALmin = "0" + finalmin;
        }
        if (finalsec < 10)
        {
            FINALsec = "0" + finalsec;
        }

        System.out.println("Interval: " + FINALhour + ":" +  FINALmin + ":" + FINALsec);

    }
}
