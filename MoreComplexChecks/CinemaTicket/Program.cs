using System;

namespace CinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();
            int price = 0;
            switch(dayOfWeek)
            {
                case "Monday":
                    price = 12;
                    break;
                case "Tuesday":
                    price = 12;
                    break;
                case "Wednesday":
                    price = 14;
                    break;
                case "Thursday":
                    price = 14;
                    break;
                case "Friday":
                    price = 12;
                    break;
                case "Saturday":
                    price = 16;
                    break;
                case "Sunday":
                    price = 16;
                    break;
            }
            Console.WriteLine(price);
        }
    }
}
