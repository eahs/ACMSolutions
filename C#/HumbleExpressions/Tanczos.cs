using System;
using System.Collections.Generic;
using ACMHelper;

namespace HumbleExpressions
{
    class Program
    {
        private static Dictionary<int, List<string>> solutions = new Dictionary<int, List<string>>();

        public static void addExpression (string expression)
        {
            int answer = expression.Evaluate();  // ACMHelper method Evaluate evaluates a string as a math expression

            if (!solutions.ContainsKey(answer))
                solutions.Add(answer, new List<string>());

            solutions[answer].Add(expression);

            
        }

        public static void generateExpressions(string prefix, int n)
        {
            if (n == 9)
            {
                addExpression(prefix + n);
                return;
            }

            generateExpressions(prefix + n + "", n + 1);
            generateExpressions(prefix + n + " + ", n + 1);
            generateExpressions(prefix + n + " - ", n + 1);

        }

        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");

            int num = Console.ReadLine().ToInteger();

            generateExpressions("", 1);

            if (solutions.ContainsKey(num))
            {
                List<string> expressions = solutions[num];
                for (int i = 0; i < expressions.Count; i++)
                {
                    Console.WriteLine("{0}. {1} = {2}", (i + 1), num, expressions[i]);
                }
            }
            else
            {
                Console.Write("{0} is not humble.", num);
            }
        }
    }
}
