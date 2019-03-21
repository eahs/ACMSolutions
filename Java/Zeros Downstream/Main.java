import java.util.Scanner;

public class Main {

    public static void main(String[] args)
    {
        Scanner keyboard = new Scanner(System.in);

        System.out.print("Enter a positive integer: ");


        System.out.println("h(n) = " + findZeros(keyboard.nextInt()));
    }


    private static int findZeros(int number)
    {
        int sol = 0;

        for (int i = 1; i < 1000; i++)
        {
            sol += number / Math.pow(5, i);
        }

        return sol;
    }
}
