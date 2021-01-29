using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if(figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine(side * side);
            }
            else if(figure == "rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                Console.WriteLine(side1 * side2);
            }
            else if(figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.PI * radius * radius);
            }
            else if(figure == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double heightA = double.Parse(Console.ReadLine());
                Console.WriteLine(sideA * heightA / 2);
            }
        }
    }
}
