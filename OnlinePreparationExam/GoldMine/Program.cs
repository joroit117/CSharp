using System;

namespace GoldMine
{
    class Program
    {
        static void Main(string[] args)
        {
            int locations = int.Parse(Console.ReadLine());
            
            for (int location = 0; location < locations; location++)
            {
                
                double averageExtractionPerDayExcpected = double.Parse(Console.ReadLine());
                int daysOnTheLocation = int.Parse(Console.ReadLine());
                double averageExtractionPerDayReal = 0;

                for (int days = 0; days < daysOnTheLocation; days++)
                {
                    double extractionForTheDay = double.Parse(Console.ReadLine());
                    averageExtractionPerDayReal += extractionForTheDay;
                }
                averageExtractionPerDayReal /= daysOnTheLocation;
                if(averageExtractionPerDayReal >= averageExtractionPerDayExcpected)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageExtractionPerDayReal:f2}.");
                }
                else
                {
                    double neededGold = averageExtractionPerDayExcpected - averageExtractionPerDayReal;
                    Console.WriteLine($"You need {neededGold:f2} gold.");
                }
            }
        }
    }
}
