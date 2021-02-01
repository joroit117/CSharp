using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minuteOfExam = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minuteOfArrival = int.Parse(Console.ReadLine());
            int hoursExam = hourOfExam * 60 + minuteOfExam;
            int hoursArrival = hourOfArrival * 60 + minuteOfArrival;
            int hours = 0;
            int minutes = 0;

            if(hoursExam > hoursArrival)
            {
                if((hoursExam - hoursArrival) >= 60)
                {
                    hours = (hoursExam - hoursArrival) / 60;
                    minutes = (hoursExam - hoursArrival) % 60;
                    Console.WriteLine("Early");
                    if(minutes < 10)
                    {
                         Console.WriteLine($"{hours}:0{minutes} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hours}:{minutes} hours before the start");
                    }
                }
                else if((hoursExam - hoursArrival) < 60)
                {
                    minutes = hoursExam - hoursArrival;
                    if(minutes <= 30)
                    {
                        Console.WriteLine("On time");
                    }
                    else
                    {
                        Console.WriteLine("Early");
                    }
                    Console.WriteLine($"{minutes} minutes before the start");
                }
            }
            else if(hoursExam == hoursArrival)
            {
                Console.WriteLine("On time");
            }
            else if(hoursExam < hoursArrival)
            {
                if ((hoursArrival - hoursExam) >= 60)
                {
                    hours = (hoursArrival - hoursExam) / 60;
                    minutes = (hoursArrival - hoursExam) % 60;
                    Console.WriteLine("Late");
                    if (minutes < 10)
                    {
                        Console.WriteLine($"{hours}:0{minutes} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hours}:{minutes} hours after the start");
                    }
                }
                else if ((hoursArrival - hoursExam) < 60)
                {
                    minutes = hoursArrival - hoursExam;
                    Console.WriteLine("Late");
                    Console.WriteLine($"{minutes} minutes after the start");
                }
            }
        }
    }
}
