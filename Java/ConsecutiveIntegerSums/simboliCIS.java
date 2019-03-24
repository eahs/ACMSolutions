import java.util.*;

// For n = 30, the highest test case, this program outputs 10395.
// That sounds correct but it could be wrong.

public class ConsecutiveIntegerSums
{
    public static void main(String [] args)
    {
        Scanner keyboard = new Scanner(System.in);
        System.out.print("Enter a positive integer: ");

        int n = keyboard.nextInt();

        System.out.print("Output: " + smallestSum(n)) ;
    }

    private static int smallestSum(int n)
    {
        // cases where answer is not divisible by 5
        if (n == 1)
            return 3;
        if (n == 2)
            return 9;

        double sol = 0;

        for (double i = 5; i <= 50000; i += 5)
        {
            int ways = 1;
            sol = i;

             for (int div = 3; div <= 50000; div++)
             {
                 if (div != i && !isPowerOfTwo(div))
                 {
                     if ( (i % 2 != 0 && i % div == 0) || (i % 2 == 0 && i % div == 0.5))
                         ways++;
                     if (ways == n)
                         return (int) sol;
                 }
             }
        }

        return (int) sol;
    }

    private static boolean isPowerOfTwo(int num)
    {
        return (num == 2 || num == 4 || num == 8 || num == 16 || num == 32 || num == 64
                || num == 128 || num == 256 || num == 512 || num == 1024 || num ==  2048
                || num == 4096 || num == 8192 || num == 16384 || num == 32768);
    }
}
