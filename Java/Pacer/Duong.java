package com.company;
import java.util.*;

public class Pacer {
    public static void main(String[] args) {
    Scanner keyboard = new Scanner(System.in);

    System.out.print("Interval in meters: ");
    int meters = ACM.toInteger(keyboard.nextLine());

    System.out.print("Target mile time: ");
    List<Integer> parts = ACM.toIntegerList(keyboard.nextLine(), ":");

    int minute = parts.get(0);
    int seconds = parts.get(1);

    double mm = (1609.0/meters);
    minute = minute * 60;
    int time = minute + seconds;

    double tm = (time/mm);
    double secMin = (tm/60);
    int min = ((int)tm/60);

    double sec = (secMin % 1);
    sec = (sec * 60);
    int finalSec = (int)sec;
    String n = ACM.padLeft(finalSec + "", 2, "0");

    System.out.println(min + ":" + n);

    }
}
