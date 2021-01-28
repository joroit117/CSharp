using System;

namespace BirthayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double naem = double.Parse(Console.ReadLine());
            double torta = 0.2 * naem;
            double napitki = torta -0.45 * torta;
            double animator = naem / 3;
            double endPrice = naem + torta + napitki + animator;
            Console.WriteLine(endPrice);
        }
    }
}
