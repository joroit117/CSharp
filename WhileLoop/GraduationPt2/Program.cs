using System;

namespace GraduationPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            double averageGrade = 0;
            int failedCount = 0;
            int gradeCount = 0;
            string name = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());
            averageGrade += grade;
            gradeCount++;
            while(gradeCount < 12)
            {
                if (grade <= 4)
                {
                    failedCount++;
                }
                if (failedCount > 1)
                {
                    break;
                }
                grade = double.Parse(Console.ReadLine());
                averageGrade += grade;
                gradeCount++;
            }
            averageGrade /= gradeCount;
            if(failedCount > 1)
            {
                Console.WriteLine($"{name} has been excluded at {gradeCount - 1} grade");
            }
            else
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}
