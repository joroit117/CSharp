using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int storage = width * length * height;
            int boxesCount = 0;
            bool endOfBoxes = false;
            
            while(boxesCount <= storage)
            {
                string boxes = Console.ReadLine();
                if(boxes == "Done")
                {
                    Console.WriteLine($"{storage - boxesCount} Cubic meters left.");
                    endOfBoxes = true;
                    break;
                }
                boxesCount += int.Parse(boxes);
            }
            if(endOfBoxes == false)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(boxesCount - storage)} Cubic meters more.");
            }
        }
    }
}
