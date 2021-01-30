using System;

namespace VacationBookList
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int numberOfDays = int.Parse(Console.ReadLine());
            double timeForBook = numberOfPages / pagesPerHour;
            double amountOfTimeNeed = timeForBook / numberOfDays;
            Console.WriteLine(amountOfTimeNeed);
        }
    }
}
