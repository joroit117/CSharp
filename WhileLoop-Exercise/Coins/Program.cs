using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            const double coin1 = 2;
            const double coin2 = 1;
            const double coin3 = 0.5;
            const double coin4 = 0.2;
            const double coin5 = 0.1;
            const double coin6 = 0.05;
            const double coin7 = 0.02;
            const double coin8 = 0.01;
            double change = double.Parse(Console.ReadLine());
            int coinCounter = 0;

            if (change >= 2)
            {
                while (change >= 2)
                {
                    
                    change -= coin1;
                    coinCounter++;
                    if (change == 0) break;
                }
            }
            change = Math.Round(change, 2);
            if (change >= 1)
            {
                while (change >= 1)
                {
                    
                    change -= coin2;
                    coinCounter++;
                    if (change == 0) break;
                }
            }
            change = Math.Round(change, 2);
            if (change >= 0.5)
            {
                while (change >= 0.5)
                {
                    
                    change -= coin3;
                    coinCounter++;
                    if (change == 0) break;
                }
            }
            change = Math.Round(change, 2);
            if (change >= 0.2)
            {
                while (change >= 0.2)
                {
                    
                    change -= coin4;
                    coinCounter++;
                    if (change == 0) break;
                }
            }
            change = Math.Round(change, 2);
            if (change >= 0.1)
            {
                while (change >= 0.1)
                {
                    
                    change -= coin5;
                    coinCounter++;
                    if (change == 0) break;
                }
            }
            change = Math.Round(change, 2);
            if (change >= 0.05)
            {
                while (change >= 0.05)
                {
                    
                    change -= coin6;
                    coinCounter++;
                    if (change == 0) break;
                }
            }
            change = Math.Round(change, 2);
            if (change >= 0.02)
            {
                while (change >= 0.02)
                {
                    
                    change -= coin7;
                    coinCounter++;
                    if (change == 0) break;
                }
            }
            change = Math.Round(change, 2);
            if (change >= 0.01)
            {
                
                while (change >= 0.01)
                {
                    
                    change -= coin8;
                    coinCounter++;
                    if (change == 0) break;
                }
            }
            Console.WriteLine(coinCounter);
        }
    }
}
