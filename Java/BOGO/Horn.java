import java.util.Scanner;

public class Horn {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String input;
        int smalls = 0;
        int mediums = 0;
        int larges = 0;
        int price = 0;
        char currentPie;

        System.out.print("Enter purchase: ");
        input = scan.next();

        for (int i = 0; i < input.length(); i++) {
            currentPie = input.charAt(i);
            if (currentPie == 'S') {
                smalls++;
                price += 2;
            } else if (currentPie == 'M') {
                mediums++;
                price += 3;
            } else {
                larges++;
                price += 5;
            }
        }

        if (smalls == 2) {
            price -= 2;
        } else if (mediums == 2) {
            price -= 3;
        } else if (larges == 2) {
            price -= 5;
        }

        System.out.println("Price: $" + price);
    }
}
