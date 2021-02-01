using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double ticketPrice = 0.0;

            if (type == "Premiere")
            {
                ticketPrice = 12;
            }
            else if(type == "Normal")
            {
                ticketPrice = 7.5;
            }
            else if(type == "Discount")
            {
                ticketPrice = 5;
            }
            ticketPrice *= rows * columns;
            Console.WriteLine($"{ticketPrice:f2} leva");
        }
    }
}
