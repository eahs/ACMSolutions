import java.util.*;

public class ParitySignature
{
    public static void main(String[] args)
    {
        Scanner keyboard = new Scanner(System.in);
        System.out.print("Enter two positive integers: ");

        int num1 = keyboard.nextInt();
        int num2 = keyboard.nextInt();
        String product = Integer.toString(num1*num2);

        System.out.println("Parity signature of product " + product + " = " + returnParitySignature(product));
    }

    private static String returnParitySignature(String num)
    {
        StringBuilder builder = new StringBuilder();

        int previous = 0;
        int total = 0;

        for (int i = 0; i < num.length(); i++)
        {
            int current = Integer.parseInt(num.substring(i, i+1)) % 2;

            if (current != previous)
            {
                 builder.append(total);
                 builder.append(" ");
                 total = 0;
                 previous = current;
            }

            total++;
        }

        if (total > 0)
            builder.append(total);

        return builder.toString();
    }

}
