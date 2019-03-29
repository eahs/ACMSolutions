using System;
using ACMHelper;

namespace Slatipac
{
    class Spaziani
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input: ");
                string input = Console.ReadLine();
                string reverse = "";
                string n = "0123456789-";

                for (int i = 0; i < input.Length; i++)
                {
                    string temp = input[i].ToString();

                    if (temp == temp.ToUpper() && !n.Contains(temp))
                    {
                        reverse += temp;
                    }
                    else if (reverse.Length > 0)
                    {                        
                        input = input.Replace(reverse, reverse.Reverse());
                        reverse = "";
                    }
                    if (i == input.Length - 1 && reverse.Length > 0)
                    {
                        input = input.Replace(reverse, reverse.Reverse());
                        reverse = "";
                    }
                }

                Console.WriteLine("Output: {0}", input);
            }
        }
    }
}
