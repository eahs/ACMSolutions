package com.company;
import java.util.*;

public class Quokka {

    public static void main(String[] args) {
        // write your code here
        Scanner keyboard = new Scanner(System.in);
        String[] numberArray = new String[3];

        System.out.print("Dice: ");

        String n = keyboard.nextLine();

        numberArray = n.split(" ");

        Integer[] nArray = new Integer[3];

        int even = 0;
        int odd = 0;
        int sum = 0;
        int eNum = 0;
        int oNum = 0;

        for(int i = 0; i < nArray.length; i++) {
            nArray[i] = Integer.parseInt(numberArray[i]);

            if (nArray[i] % 2 == 0) {
                even++;
                eNum += nArray[i];
            }
            if (nArray[i] % 2 != 0) {
                odd++;
                oNum += nArray[i];
            }
            sum = (eNum * even) + (oNum * odd);

        }

        System.out.println("Profit: $" + sum);
    }

}
