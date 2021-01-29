using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();
            if(input == "m" && output == "cm")
            {
                number *= 100;
            }
            else if (input == "m" && output == "mm")
            {
                number *= 1000;
            }
            else if (input == "cm" && output == "m")
            {
                number *= 0.01;
            }
            else if (input == "cm" && output == "mm")
            {
                number *= 10;
            }
            else if (input == "mm" && output == "m")
            {
                number *= 0.001;
            }
            else if (input == "mm" && output == "cm")
            {
                number *= 0.1;
            }
            Console.WriteLine($"{number:f3}");
        }
    }
}
