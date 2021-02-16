using System;

namespace CinemaTickets2
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();

            int totalTickets = 0;
            double standardTickets = 0;
            double kidTickets = 0;
            double studentTickets = 0;

            while(movie != "Finish")
            {
                int availableSeats = int.Parse(Console.ReadLine());

                int ticketCounter = 0;
                string ticketType = Console.ReadLine();

                while(ticketType != "End")
                {
                    ticketCounter++;

                    switch(ticketType)
                    {
                        case "standard":
                            standardTickets++;
                            break;
                        case "kid":
                            kidTickets++;
                            break;
                        case "student":
                            studentTickets++;
                            break;
                    }

                    if(ticketCounter == availableSeats)
                    {
                        break;
                    }
                    ticketType = Console.ReadLine();
                }
                totalTickets += ticketCounter;

                double percetageFull = ticketCounter * 1.0 / availableSeats * 100;
                Console.WriteLine($"{movie} - {percetageFull:f2}% full.");
                movie = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {totalTickets}");

            double standardTicketsPercent = standardTickets / totalTickets * 100;
            double studentTicketsPercent = studentTickets / totalTickets * 100;
            double kidTicketsPercent = kidTickets / totalTickets * 100;

            Console.WriteLine($"{studentTicketsPercent:f2}% student tickets.");
            Console.WriteLine($"{standardTicketsPercent:f2}% standard tickets.");
            Console.WriteLine($"{kidTicketsPercent:f2}% kid tickets.");

        }
    }
}
