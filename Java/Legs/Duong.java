package com.company;
import java.util.*;

public class Legs {
    public static void main(String[] args) {
        Scanner keyboard = new Scanner(System.in);
        System.out.print("Number of legs: ");
        int legs = keyboard.nextInt();
        int combos = 0;

        if(legs %2 != 0){
            combos = 0;
        }

        for(int people = 0; people <= legs/2; people++){

            for(int roaches = 0; roaches <= legs/6; roaches++){

                for(int spiders = 0; spiders <= legs/8; spiders++){

                    int possibleCombo = people * 2 + roaches * 6 + spiders * 8;

                    if(possibleCombo == legs) combos++;
                }
            }
        }
        System.out.println(combos + " possible combinations of people, spiders, and cockroaches.");

    }
}
