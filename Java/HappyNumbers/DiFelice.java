package com.difelice;
import java.util.*;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class HappyNumbers {

    public static int squareDigits (int num)
    {
        int result = 0;
        while (num!= 0)
        {
            int k = num % 10;
            result += (k * k);
            num /= 10;
        }
        // 32 = 3^2 + 2^2
        return result;
    }

    public static boolean isHappy (int num)
    {
        // To be done by not Tanczos
        ArrayList<Integer> solutions = new ArrayList<Integer>();

        do
        {
            num = squareDigits(num);

            if (solutions.contains(num))
                return false;

            solutions.add(num);
        }
        while (num != 1);

        return true;
    }

    public static void main(String[] args) {
        // write your code here
        Scanner scan = new Scanner(System.in);

        System.out.print("Enter a positive integer: ");
        int want = scan.nextInt();

        List<Integer> nums = IntStream.rangeClosed(1,1000000).filter(i -> isHappy(i)).boxed().collect(Collectors.toList());
        List<String>  happypairs = new ArrayList<String>();
        for(int i = 0; i < nums.size()-1; i++)
        {
            int diff = nums.get(i + 1)- nums.get(i);
            if ( diff == 1)
            {
                happypairs.add(nums.get(i) + "-" + nums.get(i + 1));
            }
        }
    System.out.println("Happy pair: " + happypairs.get(want - 1));
    }
}
