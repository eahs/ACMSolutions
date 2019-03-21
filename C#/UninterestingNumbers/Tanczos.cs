using System;

namespace UninterestingNumbers
{
    class Program
    {
        public static int findIndexofThree (string num)
        {
            for (int i = 0; i < num.Length-2; i++)
            {
                if (num[i] == num[i + 1] && num[i] == num[i + 2])
                    return i;
            }
            return -1;
        }

        public static string validate (string input)
        {
            string suffix = "001001001001001001001001001", output = "";

            int index = findIndexofThree(input);

            // If we can't find three in a row, just turn to a number and add 1
            if (index == -1)
            {
                output = Convert.ToUInt64(input) + 1 + "";
            }
            else
            {
                // found three in a row so increment that part and append the correct
                // length for the suffix pattern
                output = Convert.ToUInt64(input.Substring(0, index + 3)) + 1 + "";
                output = output + suffix.Substring(0, input.Length - index - 3);
            }

            return output;
        }

        static void Main(string[] args)
        {
            string output = "";

            Console.Write("Input: ");
            string input = Console.ReadLine();

            output = validate(input);

            while (findIndexofThree(output) != -1)
                output = validate(output);

            Console.Write("Output: {0}", output);
        }
    }
}
