package com.company;

import java.util.*;

public class BOGO {
    public static void main (String[] args)
    {
        String purchase = "";
        int sCount = 0;
        int mCount = 0;
        int lCount = 0;
        int sum;
        System.out.println("Enter Customer Purchase: ");
        Scanner scan = new Scanner(System.in);
        purchase = scan.nextLine();

        for(int i = 0; i < purchase.length(); i++)
        {
            String size = purchase.substring(i, i + 1);

            if(size.equals("s"))
            {
                sCount += 1;
            }
            if(size.equals("m"))
            {
                mCount += 1;
            }
            if(size.equals("l"))
            {
                lCount += 1;
            }
        }

        if(sCount > 1)
        {
            sCount = 1;
        }
        if(mCount > 1)
        {
            mCount = 1;
        }
        if(lCount > 1)
        {
            lCount = 1;
        }

        sum = (sCount * 2) + (mCount * 3) + (lCount *5);
        System.out.println(sCount);
        System.out.println(mCount);
        System.out.println(lCount);
        System.out.println("Sum: " + sum);
    }
}
