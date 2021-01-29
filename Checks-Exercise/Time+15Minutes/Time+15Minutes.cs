using System;

namespace Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            if(minutes >= 45 && hours != 23)
            {
                hours++;
                minutes = minutes - 45;
            }
            else if (minutes >= 45 && hours == 23)
            {
                hours = 0;
                minutes = minutes - 45;
            }
            else
            {
                minutes += 15;
            }
            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
