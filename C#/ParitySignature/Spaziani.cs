using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parity_Signature
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] inputs = new string[2];

                Console.Write("Enter two positive integers: ");
                inputs = Console.ReadLine().Split(' ').ToArray();

                long num1 = Convert.ToInt64(inputs[0]);
                long num2 = Convert.ToInt64(inputs[1]);

                string Product = (num1 * num2).ToString();

                Calculate(Product);
            }
        }

        public static void Calculate(string words)
        {
            string answer = "";

            List<string> Parity = new List<string>();
            int Enums = 0;
            int Onums = 0;
            int Counter = 0;

            foreach (char c in words)
            {
                
                if (c % 2 == 0)
                {
                    Enums++;
                    if (Onums > 0)
                    {
                        Parity.Add(Onums.ToString());
                        Onums = 0;
                    }
                }
                if (c % 2 != 0)
                {
                    if (Counter == 0)
                    {
                        Parity.Add(Enums.ToString());
                    }
                    Onums++;
                    if (Onums > 0 && Enums > 0)
                    {
                        Parity.Add(Enums.ToString());
                        Enums = 0;
                    }
                }
                Counter++;
            }

            if (Enums > 0)
            {
                Parity.Add(Enums.ToString());
            }
            if (Onums > 0)
            {
                Parity.Add(Onums.ToString());
            }

            for (int i = 0; i < Parity.Count; i++)
            {
                answer += Parity[i] + " ";
            }

            Console.Write("Parity signature of product " + words + " = " + answer);
            Console.WriteLine("\n");

        }
    }
}
