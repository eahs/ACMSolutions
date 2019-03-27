import java.text.DecimalFormat;
import java.util.Scanner;

public class Pacer {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        DecimalFormat df = new DecimalFormat(".2f");
        float distance, result, intervalDist;
        int mileTime;
        String input, time, seconds;

        System.out.print("Interval distance in meters: ");
        distance = scan.nextFloat();
        System.out.print("Target mile pace: ");
        input = scan.next();

        String[] pace = input.split(":");
        mileTime = Integer.parseInt(pace[0])*60 + Integer.parseInt(pace[1]);

        intervalDist = (1609/distance);
        result = mileTime/intervalDist;
        time = (int)(result/60) + ":" + (result%60);
        if (Integer.toString((int)(result%60)).length() < 2) {
            seconds = 0 + Integer.toString((int)(result%60));
        } else {
            seconds = Integer.toString((int)(result%60));
        }
        System.out.println((int)(result/60) + ":" + seconds);
    }
}
