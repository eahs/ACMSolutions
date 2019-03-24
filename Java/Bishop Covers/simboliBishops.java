import java.util.*;

public class BishopCovers
{
    public static void main(String [] args)
    {
        int[][] board = new int[8][8];
        int rowOne, colOne;
        int rowTwo, colTwo;

        Scanner keyboard = new Scanner(System.in);

        System.out.print("Row and column of first bishop: ");
        rowOne = keyboard.nextInt() - 1;
        colOne = keyboard.nextInt() - 1;

        System.out.print("Row and column of second bishop: ");
        rowTwo = keyboard.nextInt() - 1;
        colTwo = keyboard.nextInt() - 1;

        int[][] board1 = coverSquares(rowOne, colOne, board);
        int[][] board2 = coverSquares(rowTwo, colTwo, board1);

        System.out.println(coveredSquares(board2) + " squares covered.");
    }

    private static int coveredSquares (int[][] board)
    {
        int count = 0;
        for (int i = 0; i < board.length; i++)
        {
            for (int j = 0; j < board.length; j++)
                if (board[i][j] == 1)
                    count++;
        }
        return count;
    }

    private static int[][] coverSquares(int row, int col, int[][] board)
    {
        int r1 = row; int r2 = row; int r3 = row;
        int c1 = col; int c2 = col; int c3 = col;

        //NE diagonal
        while (row < board.length && col < board.length)
        {
            if (board[row][col] == 0)
                board[row][col] = 1;
            row++;
            col++;
        }
        //NW
        while (r1 < board.length && c1 >= 0)
        {
            if (board[r1][c1] == 0)
                board[r1][c1] = 1;
            r1++;
            c1--;
        }
        //SE
        while (r2 >= 0 && c2 < board.length)
        {
            if (board[r2][c2] == 0)
                board[r2][c2] = 1;
            r2--;
            c2++;
        }
        //SW
        while (r3 >= 0 && c3 >= 0)
        {
            if (board[r3][c3] == 0)
                board[r3][c3] = 1;
            r3--;
            c3--;
        }
        return board;
    }
}
