import java.util.*;

public class Horn {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int n;
        int pointsVisible = 0;

        System.out.print("Enter grid size: ");
        n = scan.nextInt();

        for (int i = 1; i <= n; i++) {
            for (int j = 1; j <= n;  j++) {
                if (ACM.greatestCommonDivisor(i, j) == 1) {
                    pointsVisible++;
                }
            }
        }

        pointsVisible += 2;
        System.out.println("Points visible: " + pointsVisible);

    }
}