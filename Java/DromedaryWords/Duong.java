package com.company;
import java.util.*;

public class DromedaryWords {
    public static void main(String[] args) {

        Scanner keyboard = new Scanner(System.in);

        System.out.print("Enter a word: ");
        String word = keyboard.nextLine();

        int greatest = 0;
        for (int i = 0; i < word.length(); i++) {
            if (word.charAt(i) > word.charAt(greatest)) greatest = word.indexOf(word.charAt(i));
        }

        boolean increasing = isIncreasing(word, greatest);
        boolean decreasing = isDecreasing(word, greatest);

        if(increasing && decreasing) {
            System.out.println(word + " is a dromedary word.");
        }
        else {
            System.out.println(word + " is NOT a dromedary word.");
        }
    }

    private static boolean isIncreasing(String Word, int Greatest)
    {

        for(int i = 0; i < Greatest; i++)
        {
            if(Word.charAt(i) >= Word.charAt(i + 1)) return false;
        }
        return true;
    }

    private static boolean isDecreasing(String Word, int Greatest)
    {
        for(int i = Greatest; i < Word.length()- 1; i++)
        {
            if(Word.charAt(i) <= Word.charAt(i + 1))  return false;
        }
        return true;
    }
}
