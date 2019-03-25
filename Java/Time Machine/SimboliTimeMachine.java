package org.eastonsd;

import java.time.*;
import java.util.Scanner;

public class TimeMachine
{
    public static void main(String[] args)
    {
        Scanner keyboard = new Scanner(System.in);
        System.out.print("Enter time travel integer: ");

        int travel = keyboard.nextInt();

        LocalDate dt = LocalDate.of(2014, 4, 22);
        LocalDate dt1 = dt.plusDays(travel);

        System.out.println("You will be transported to: " + dt1.getMonthValue() + "/"
        + dt1.getDayOfMonth() + "/" + dt1.getYear());
    }
}
