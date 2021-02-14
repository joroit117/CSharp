using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            const int goal = 10000;
            int stepsCounter = 0;

            while(stepsCounter < goal)
            {
                string steps = Console.ReadLine();
                if (steps == "Going home")
                {
                    steps = Console.ReadLine();
                    stepsCounter += int.Parse(steps);
                    break;
                }
                stepsCounter += int.Parse(steps);
            }
            if(stepsCounter < goal)
            {
                Console.WriteLine($"{goal - stepsCounter} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsCounter - goal} steps over the goal!");
            }
        }
    }
}
