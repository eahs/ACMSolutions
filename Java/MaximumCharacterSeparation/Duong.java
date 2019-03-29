package com.company;
import java.util.*;

public class MaximumCharacterSeparation {
    public static void main(String[] args) {
        Scanner keyboard = new Scanner(System.in);

        System.out.println("Word: ");
        String word = keyboard.nextLine();

        int maxSep = 0;

        for(int i = 0; i < word.length() - 1; i++)
        {
            int firstIndex = word.indexOf(word.substring(i, i+1));
            int lastIndex = word.lastIndexOf(word.substring(i, i+1));
            int maybeMax = lastIndex - firstIndex;
            if(maybeMax > maxSep) maxSep = maybeMax;
        }
        System.out.println("Maximum Character Separation: " + maxSep);
    }
}
