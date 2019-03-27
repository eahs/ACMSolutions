import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

public class Horn {
    public static void main (String[] args) {
        Scanner scan = new Scanner(System.in);
        ArrayList<Integer> input = new ArrayList<>();
        ArrayList<Integer> sorted;
        int product = 0;

        System.out.print("Enter three coordinates: ");

        for (int i =0; i < 3; i++)
            input.add(scan.nextInt());

        sorted = new ArrayList<>(input);
        Collections.sort(sorted);

        for (int i = 0; i < input.size(); i++)
            product += input.get(i) * sorted.get(i);

        System.out.println("Dot twist: " + product);
    }
}
