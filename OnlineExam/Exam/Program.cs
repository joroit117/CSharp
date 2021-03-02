﻿using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            double topstudents = 0;
            double verygood = 0;
            double good = 0;
            double fail = 0;
            double average = 0;

            for(int i = 0; i < numberOfStudents; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if(grade >= 5)
                {
                    topstudents++;
                }
                else if(grade >= 4 && grade <= 4.99)
                {
                    verygood++;
                }
                else if(grade >= 3 && grade <= 3.99)
                {
                    good++;
                }
                else
                {
                    fail++;
                }
                average += grade;
            }

            topstudents = topstudents / numberOfStudents * 100;
            verygood = verygood / numberOfStudents * 100;
            good = good / numberOfStudents * 100;
            fail = fail / numberOfStudents * 100;

            average /= numberOfStudents;

            Console.WriteLine($"Top students: {topstudents:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {verygood:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {good:f2}%");
            Console.WriteLine($"Fail: {fail:f2}%");
            Console.WriteLine($"Average: {average:f2}");

        }
    }
}
