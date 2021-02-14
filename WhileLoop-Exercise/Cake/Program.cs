using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int pieces = width * length;
            int piecesEaten = pieces;
            bool isEnough = false;

            string piecesTaken = "";

            while(piecesEaten >= 0)
            {
                piecesTaken = Console.ReadLine();
                if(piecesTaken == "STOP")
                {
                    isEnough = true;
                    break;
                }
                piecesEaten -= int.Parse(piecesTaken);
            }
            if(isEnough)
            {
                Console.WriteLine($"{piecesEaten} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(piecesEaten)} pieces more.");
            }
        }
    }
}
