package com.company;
import java.util.*;
public class Main {

    public static void main(String[] args) {
	Scanner keyboard = new Scanner(System.in);
	System.out.println("Starting configuration: ");
	String moves = keyboard.nextLine();
	String a1 = moves.substring(0,1);
	String a2 = moves.substring(1,2);
	int a1Pos = Integer.parseInt(a1);
	int a2Pos = Integer.parseInt(a2);
	String first = moves.substring(2,3);

	int a1Final = 8 - a1Pos;
	int a2Final = a2Pos -1;
	if (a1Final > a2Final)
	{
		System.out.println("The DOWN ant wins after " + a2Final + " move(s).");
	}
	else
	{
		System.out.println("The UP ant wins after " + a1Final + " move(s).");
	}
    }
}
