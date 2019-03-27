package com.company;
import java.util.*;

public class VowelShifter {
    public static void main(String[] args) {
        Scanner keyboard = new Scanner(System.in);

        System.out.println("Enter a sentence. ");
        String input = keyboard.nextLine();

        String output = "";
        String original = "aeiouAEIOU";
        String sub = "eiouaEIOUA";

        for(int i = 0; i < input.length(); i++)
        {
            int index = original.indexOf(input.substring(i, i+1));
            if(index == -1)
            {
                output += input.substring(i, i+1);
            }
            else
            {
                output += sub.substring(index, index+1);
            }
        }
        System.out.println(output);
    }
}
