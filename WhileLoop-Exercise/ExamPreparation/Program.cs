using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedNumber = int.Parse(Console.ReadLine());
            int failedTimes = 0;
            bool isFailed = true;
            int solvedTasksCount = 0;
            double gradesSum = 0;
            string lastTask = "";

            while(failedTimes < failedNumber)
            {
                string taskName = Console.ReadLine();
                if(taskName == "Enough")
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if(grade <= 4)
                {
                    failedTimes++;
                }
                gradesSum += grade;
                solvedTasksCount++;
                lastTask = taskName;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failedNumber} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradesSum / solvedTasksCount:f2}");
                Console.WriteLine($"Number of problems: {solvedTasksCount}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
        }
    }
}
