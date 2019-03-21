using System;

namespace ACM
{
    class Quagga
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int last = 0;
                int Quag = 0;

                bool NO = true;
                Console.Write("Enter dice number: ");
                string[] roll = Console.ReadLine().Split(' ');

                for (int i = 0; i < 2; i++)
                {
                    for (int j = i + 1; j < 3; j++)
                    {
                        if (roll[i] == "1" || roll[j] == "1")
                            NO = false;

                        int nums = Convert.ToInt32(string.Concat(roll[i], roll[j]));
                        int nums2 = Convert.ToInt32(string.Concat(roll[j], roll[i]));
                        if (i == 0 && j == 1)
                            last = Convert.ToInt32(roll[2]);
                        else if (i == 0 && j == 2)
                            last = Convert.ToInt32(roll[1]);
                        else
                            last = Convert.ToInt32(roll[0]);

                        if (nums % last == 0 || nums2 % last == 0)
                            Quag++;
                    }
                }
                if (NO)
                {
                    if (Quag > 0)
                        Console.WriteLine("That's a QUAGGA!");
                }
                else
                    Console.WriteLine("Sorry, no QUAGGA.");
            }
        }
    }
}
