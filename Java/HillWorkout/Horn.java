import java.util.Scanner;

public class Horn {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int x, y, n;

        System.out.print("Enter x, y, and n: ");
        x = scan.nextInt();
        y = scan.nextInt();
        n = scan.nextInt();

        System.out.println("Workout distance: " + calcDist(x, y, n) + " miles.");
    }

    public static int calcDist(int x, int y, int n) {
        int miles = 0;
        int pos = 0;

        while (true) {
            for (int i = 0; i < x; i++) {
                if (pos == n) {
                    return miles;
                } else {
                    miles += 1;
                    pos += 1;
                }
            }

            for (int i = 0; i < y; i++) {
                if (pos == n) {
                    return miles;
                } else {
                    miles += 1;
                    pos -= 1;
                }
            }
        }
    }
}
