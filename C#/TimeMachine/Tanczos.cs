using System;

namespace TimeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter time travel integer: ");
            int n = Convert.ToInt32(Console.ReadLine());

            DateTime dt = new DateTime(2014, 4, 22);
            DateTime future = dt.AddDays(n);

            Console.WriteLine("You will be transported to: {0}/{1}/{2}", future.Month, future.Day, future.Year);
        }
    }
}
