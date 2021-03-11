using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "";
            int sumPrime = 0;
            int sumNonPrime = 0;
            while (number != "stop")
            {
                number = Console.ReadLine();
                if(number == "stop")
                {
                    break;
                }
                else
                {
                    int x = int.Parse(number);
                    bool isNonPrime = false;
                    if (x < 0)
                    {
                        Console.WriteLine("Number is negative.");
                    }
                    else
                    {
                        if (x != 0)
                        {
                            for (int i = 2; i < x; i++)
                            {
                                if (x % i == 0)
                                {
                                    isNonPrime = true;
                                    break;
                                }
                            }
                        }
                        if(isNonPrime == true)
                        {
                            sumNonPrime += x;
                        }
                        else
                        {
                            sumPrime += x;
                        }
                    }
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");

        }
    }
}
