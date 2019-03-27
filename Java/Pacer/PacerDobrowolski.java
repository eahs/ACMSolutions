package com.company.Defelice_And_Dobrowolski;

import java.util.Scanner;

public class PacerDobrowolski {
    public static void main(String[] args)
    {
        Scanner scan = new Scanner(System.in);

        System.out.print("Interval distance in meters: ");
        int distance = scan.nextInt();

        System.out.print("Target mile pace: ");
        String pace = scan.next();

        double mile = 1609.0;

        String[] parts = pace.split(":");

        int seconds = 0;

        seconds = seconds + (Integer.parseInt(parts[0]) * 60);
        seconds = seconds + Integer.parseInt(parts[1]);

        double milePace = mile / seconds;

        double distToMile = mile / distance;

        int finalSec = (int) (seconds / distToMile);

        int min = finalSec / 60;

        String sec =  "" + (int) (finalSec % 60);

        if ((finalSec % 60) < 10)
        {
            sec = ACM.padLeft(sec, 2, "0");
        }

        String answer = min + ":" + sec;

        System.out.println(answer);

    }
}
