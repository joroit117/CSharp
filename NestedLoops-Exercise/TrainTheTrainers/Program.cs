using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string presentation = "";
            double averageGrades = 0;
            int presentationCounter = 0;
            double averageTotal = 0;

            while (presentation != "Finish")
            {
                presentation = Console.ReadLine();
                if(presentation == "Finish")
                {
                    break;
                }
                presentationCounter++;
                for(int i = 0; i < n; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    averageGrades += grade;
                }
                averageGrades /= n;
                Console.WriteLine($"{presentation} - {averageGrades:f2}.");
                averageTotal += averageGrades;
                averageGrades = 0;
            }
            averageTotal /= presentationCounter;
            Console.WriteLine($"Student's final assessment is {averageTotal:f2}.");
        }
    }
}
