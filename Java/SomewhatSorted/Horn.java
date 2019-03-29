import java.util.ArrayList;
import java.util.Scanner;

public class Horn {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int length;
        boolean isSorted = true;
        ArrayList<Integer> input;

        System.out.print("Length of sequence: ");
        length = scan.nextInt();
        input = new ArrayList<>(length);
        System.out.print("Terms of sequence: ");
        for (int i = 0; i < length; i++) input.add(scan.nextInt());

        for (int i = 0; i < input.size(); i++) {
            if (!(check(input.get(i), input))) {
                isSorted = false;
                break;
            }
        }

        System.out.println((isSorted + "").toUpperCase());
    }

    public static boolean check(int num, ArrayList<Integer> foo) {
        foo.subList(foo.lastIndexOf(num), foo.size()).clear();

        if (foo.contains(num-1) || num == 1) return true;
        else return false;
    }
}
