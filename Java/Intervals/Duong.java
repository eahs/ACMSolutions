package com.company;
import java.util.*;

public class Intervals {
    public static void main(String[] args) {
        Scanner keyboard = new Scanner(System.in);

        int h = 0;
        int m = 0;
        int s = 0;

        System.out.print("Clock time: ");
        int hours = keyboard.nextInt();
        int minutes = keyboard.nextInt();
        int seconds = keyboard.nextInt();

        System.out.print("Clock time: ");
        int hours2 = keyboard.nextInt();
        int minutes2 = keyboard.nextInt();
        int seconds2 = keyboard.nextInt();

        //if(hours > hours2) {

            h = hours2 - hours - 1;
            m = minutes2 - minutes;
            s = seconds2 - seconds;

        //}
        /*else{
            h = hours - hours2 ;
            m = minutes - minutes2;
            s = seconds - seconds2;
        }*/

        if(h < 0 || h > 24){
            h = h + 24;
        }
        if(m < 0 || m > 60){
            m = m + 60;
        }
        if(s < 0 || s > 60){
            s = s + 60;
        }
        if(h > hours || h > hours2){
            h = hours - hours2 - 1;
            m = 60 - m;
            s = 60 - s;
        }

        String hs = ACM.padLeft(h + "",2, "0");
        String ms = ACM.padLeft(m + "",2, "0");
        String ss = ACM.padLeft(s + "",2, "0");

        System.out.println("Interval: " + hs + ":" + ms + ":" + ss);

    }
}
