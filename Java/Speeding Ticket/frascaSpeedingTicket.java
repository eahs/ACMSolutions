package com.company;
import java.util.*;

public class frascaSpeedingTicket {
    public static void main(String[] args){
        int speed, base, low, mid, high, sum;
        Scanner scan = new Scanner(System.in);

        System.out.println("Enter MPH over the speed limit: ");
        speed = scan.nextInt();
        System.out.println("Enter base fee: ");
        base = scan.nextInt();

        if(speed >= 15)
        {
            high = (speed - 15) * base * 4;
            mid = 10 * base * 2;
            low = 5 * base;
        }
        else if(speed >= 5)
        {
            high = 0;
            mid = (speed - 5) * base * 2;
            low = 5 * base;
        }
        else
        {
            high = 0;
            mid = 0;
            low = speed * base;
        }

        sum = low + mid + high;
        System.out.print("Cost of ticket: " + sum);
    }
}
