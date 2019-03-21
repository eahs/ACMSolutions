package com.company;

import java.util.*;

public class Main
{

    private static ArrayList<String> solutions = new ArrayList<>();

    public static void main(String[] args)
    {
        Scanner keyboard = new Scanner(System.in);
        System.out.print("Input: ");

        String input = keyboard.next();

        System.out.println("Output: " + subsub(input));
    }

    private static String subsub(String input)
    {
        if (input.length() == 2)
        {
            if (solutions.isEmpty())
                return "NO SOLUTION";

            return Collections.max(solutions, Comparator.comparing(String::length));
        }


        for (int groups = 1; groups < input.length() / 2; groups++)
        {

                String s1 = input.substring(0, groups);
                String s2 = input.substring(groups, groups + groups);

                if (s1.equals(s2))
                    solutions.add(s1);
        }
        
        return  subsub(input.substring(1));





    }
}
