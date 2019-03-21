package com.company.Defelice_And_Dobrowolski;

import java.util.Scanner;

public class VowelShifterDifeloski {
    public static void main(String[] args)
    {
        //Dobrowolski and Difelice

        //Your powers are weak, old man!
        //I find your lack of faith disturbing.
        //I can take you as far as Anchorhead.

        Scanner scan = new Scanner(System.in);

        System.out.print("Input a sentence:");
        String sentence = scan.nextLine();

        //for each of the letters in a sentence, check for the occurance of vowels, hen change vowel

        for (int i = 0; i < sentence.length();i++)
        {
            char letter = sentence.charAt(i);

            if (letter == 'a')
            {
                sentence = sentence.substring(0,i) + "e" + sentence.substring(i+1);
            }
            else if (letter == 'e')
            {
                sentence = sentence.substring(0,i) + "i" + sentence.substring(i+1);
            }
            else if (letter == 'i')
            {
                sentence = sentence.substring(0,i) + "o" + sentence.substring(i+1);
            }
            else if (letter == 'o')
            {
                sentence = sentence.substring(0,i) + "u" + sentence.substring(i+1);
            }
            else if (letter == 'u')
            {
                sentence = sentence.substring(0,i) + "a" + sentence.substring(i+1);
            }
            else if (letter == 'A')
            {
                sentence = sentence.substring(0,i) + "E" + sentence.substring(i+1);
            }
            else if (letter == 'E')
            {
                sentence = sentence.substring(0,i) + "I" + sentence.substring(i+1);
            }
            else if (letter == 'I')
            {
                sentence = sentence.substring(0,i) + "O" + sentence.substring(i+1);
            }
            else if (letter == 'O')
            {
                sentence = sentence.substring(0,i) + "U" + sentence.substring(i+1);
            }
            else if (letter == 'U')
            {
                sentence = sentence.substring(0,i) + "A" + sentence.substring(i+1);
            }

        }
        System.out.println(sentence);
    }
}







