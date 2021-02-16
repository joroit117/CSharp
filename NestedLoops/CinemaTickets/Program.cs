using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double moviePercentage = 0;
            int ticketsCounter = 0;
            double studentPercentage = 0;
            double standardPercentage = 0;
            double kidsPercentage = 0;
            string ticket = "";

            while (ticket != "Finish")
            {
                string movie = Console.ReadLine();
                double freePlaces = int.Parse(Console.ReadLine());
                double takenPlaces = 0;
                ticket = "";
                
                while(takenPlaces <= freePlaces && ticket != "End" && ticket != "Finish")
                {
                    ticketsCounter++;
                    takenPlaces++;
                    ticket = Console.ReadLine();
                    if(ticket == "student")
                    {
                        studentPercentage++;
                    }
                    else if(ticket == "standard")
                    {
                        standardPercentage++;
                    }
                    else if(ticket == "kid")
                    {
                        kidsPercentage++;
                    }
                }
                takenPlaces--;
                ticketsCounter--;
                moviePercentage = takenPlaces / freePlaces * 100;
                Console.WriteLine($"{movie} - {moviePercentage:f2}% full.");
            }
            studentPercentage = studentPercentage / ticketsCounter * 100;
            standardPercentage = standardPercentage / ticketsCounter * 100;
            kidsPercentage = kidsPercentage / ticketsCounter * 100;

            Console.WriteLine($"Total tickets: {ticketsCounter}");
            Console.WriteLine($"{studentPercentage:f2}% student tickets.");
            Console.WriteLine($"{standardPercentage:f2}% standard tickets.");
            Console.WriteLine($"{kidsPercentage:f2}% kids tickets.");
        }
    }
}
