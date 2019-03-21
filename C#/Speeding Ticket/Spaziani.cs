using System;

namespace ACM
{
    class SpeedingTicket
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int ticket = 0;

                Console.Write("Speed in MPH over the limit: ");
                int speed = Convert.ToInt32(Console.ReadLine());

                Console.Write("Base fee: ");
                int fee = Convert.ToInt32(Console.ReadLine());
                while (speed > 0)
                {
                    if (speed <= 5)
                    {
                        ticket += (fee * speed);
                        speed -= speed;
                    }
                    if (speed >= 5)
                    {
                        ticket += ((fee) * 5);
                        speed -= 5;
                        if (speed < 15)
                        {
                            ticket += ((fee * 2) * (speed));
                            speed -= 5;
                        }
                        else
                        {
                            ticket += ((fee * 4) * (speed - 5));
                            speed -= speed;
                        }
                    }
                }
                Console.WriteLine("Cost of ticket: $" + ticket);
            }
        }
    }
}
