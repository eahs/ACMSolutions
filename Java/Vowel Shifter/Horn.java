import java.util.Scanner;

public class Horn {
    public static void main(String args[]) {
        Scanner scan = new Scanner(System.in);
        String input;

        System.out.println("Enter a sentence.");
        input = scan.nextLine();

        char[] phrase = toCharArray(input);

        for (int i = 0; i < phrase.length; i++) {
            if (isVowel(phrase[i])) {
                phrase[i] = shiftVowel(phrase[i]);
            }
        }

        input = String.copyValueOf(phrase);
        System.out.println(input);
    }

    public static char shiftVowel (char c) {
        boolean upperCase = Character.isUpperCase(c);
        c = Character.toLowerCase(c);

        if (c == 'a') {
            c = 'e';
        } else if (c == 'e') {
            c = 'i';
        } else if (c == 'i') {
            c = 'o';
        } else if (c == 'o') {
            c = 'u';
        } else {
            c = 'a';
        }

        if (upperCase)
            return Character.toUpperCase(c);
        else
            return c;
    }

    public static boolean isVowel (char c) {
        c = Character.toLowerCase(c);
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            return true;
        else
            return false;
    }

    public static char[] toCharArray (String s) {
        char[] arr = new char[s.length()];
        for (int i = 0; i < s.length(); i++) {
           arr[i] = s.charAt(i);
        }

        return arr;
    }
}
