using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            while(destination != "End")
            {
                double neededSum = double.Parse(Console.ReadLine());
                double budget = 0;

                while(budget < neededSum)
                {
                    double savedMoney = double.Parse(Console.ReadLine());
                    budget += savedMoney;
                }

                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
