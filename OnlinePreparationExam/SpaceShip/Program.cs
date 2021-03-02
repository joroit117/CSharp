using System;

namespace SpaceShip
{
    class Program
    {
        static void Main(string[] args)
        {
            double spaceShipWidth = double.Parse(Console.ReadLine());
            double spaceShipLength = double.Parse(Console.ReadLine());
            double spaceShipHeight = double.Parse(Console.ReadLine());
            double middleHeightAstronaut = double.Parse(Console.ReadLine());

            double spaceShipVolume = spaceShipWidth * spaceShipLength * spaceShipHeight;
            double roomVolume = (middleHeightAstronaut + 0.4) * 2 * 2;

            double numberAstronauts = spaceShipVolume / roomVolume;
            double numberAstronautsRounded = Math.Floor(numberAstronauts);

            if (numberAstronautsRounded < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if(numberAstronautsRounded > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
            else
            {
                Console.WriteLine($"The spacecraft holds {numberAstronautsRounded} astronauts.");
            }
        }
    }
}
