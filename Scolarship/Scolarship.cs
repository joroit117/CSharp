using System;

namespace Scolarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double average = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double scholarshipForExcellentResults = Math.Floor(average * 25);
            double socialScholarship = Math.Floor(0.35 * minSalary);

            if (average >= 5.5 && income >= minSalary)
            {
                Console.WriteLine($"You get a scholarship for excellent results {scholarshipForExcellentResults} BGN");
            }
            else if (income >= minSalary && average < 5.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if(average >= 5.5 && income < minSalary)
            {
                if (scholarshipForExcellentResults > socialScholarship) 
                    Console.WriteLine($"You get a scholarship for excellent results {scholarshipForExcellentResults} BGN");
                else
                    Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }
            else if(average >= 4.5 && income < minSalary)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }
            else if(income < minSalary && average < 4.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
