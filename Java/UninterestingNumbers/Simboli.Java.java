package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args)
    {
	    Scanner keyboard = new Scanner(System.in);

        System.out.print("Input: ");

        String number = keyboard.next();

        System.out.println("Output: " + nextInterestingNumber(number));

    }

    private static String nextInterestingNumber(String number)
    {
        String pattern = "001001001001001001001001001001001";

        int len = number.length() - stem(number).length();

        return stem(number) + pattern.substring(0, len);
    }

    private static String stem(String number)
    {
        for (int i = 0; i < number.length() - 2; i++)
        {
            String one = number.substring(i, i + 1);
            String two = number.substring(i + 1, i + 2);
            String three = number.substring(i + 2, i + 3);

            if (one.equals(two) && one.equals(three) )
            {
                return Integer.toString(Integer.parseInt(number.substring(0, i + 3)) + 1);
            }
        }
        return null;
    }
}
