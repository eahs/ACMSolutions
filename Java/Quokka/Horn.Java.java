import java.util.Scanner;

public class Quokka {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int[] nums = new int[3];
        int evens = 0;
        int odds = 0;
        int sumEvens = 0;
        int sumOdds = 0;
        int profit;

        System.out.print("Dice: ");

        for (int i = 0; i < nums.length; i++) {
            nums[i] = scan.nextInt();
        }

        for (int num :
                nums) {
            if (num % 2 == 0) {
                evens++;
                sumEvens += num;
            } else {
                odds++;
                sumOdds += num;
            }
        }

        profit = (evens * sumEvens) + (odds * sumOdds);
        System.out.println("Profit: $" + profit);
    }
}
