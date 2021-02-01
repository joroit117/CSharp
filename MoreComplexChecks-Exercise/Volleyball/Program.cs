using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double holidays = int.Parse(Console.ReadLine());
            double weekends = int.Parse(Console.ReadLine());
            double games = 48;

            games -= weekends;
            games *= 0.75;
            games += weekends;
            games += (holidays * 2 / 3);

            if (year == "leap")
            {
                games += 0.15 * games;
            }
            Console.WriteLine(Math.Floor(games));

        }
    }
}
