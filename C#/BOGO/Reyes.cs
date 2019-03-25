using System;

namespace BuyOneGetOneFree
{
    class Reyes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter purchase: ");
            string purchase = Console.ReadLine();
            char[] orders = purchase.ToCharArray();
            int Price = 0;
            for(int x = 0; x < orders.Length; x = x + 1)
            {
                if(orders[x].Equals('S'))
                {
                    Price = Price + 2;
                }
                if (orders[x].Equals('M'))
                {
                    Price = Price + 3;
                }
                if (orders[x].Equals('L'))
                {
                    Price = Price + 5;
                }
            }
            Console.WriteLine("Price: $" + Price);
        }
    }
}
