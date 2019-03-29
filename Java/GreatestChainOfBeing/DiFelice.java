package com.difelice;
import java.util.*;

public class GreatestChainofBeing {
    public static void main (String[] args){
        Scanner scan = new Scanner(System.in);

        System.out.print("Size of list: ");
        scan.nextInt();

        System.out.print("Numbers in list: ");
        scan.nextLine();
        String temp2 = scan.nextLine();

        List<String> numbers = ACM.toStringList(temp2);

        Collections.sort(numbers);
        Collections.reverse(numbers);

        for (int i = 0; i < numbers.size() - 1; i ++)
        {
            if (numbers.get(i)
                    .substring(0,1)
                    .equals(numbers
                            .get(i + 1)
                            .substring(0,1)))
            {
                String toget = numbers.get(i) + numbers.get(i+1);
                String toget2 = numbers.get(i + 1) + numbers.get(i);
                if (toget2.compareTo(toget) > 0)
                {
                    String temp = numbers.get(i);
                    numbers.set(i, numbers.get(i + 1));
                    numbers.set(i + 1, temp);
                }
            }
        }

        for (String num: numbers)
        {
            System.out.print(num);
        }

    }
}
