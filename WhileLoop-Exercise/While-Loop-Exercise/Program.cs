using System;

namespace While_Loop_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            bool isBookFound = false;
            string favoriteBook = Console.ReadLine();
            string nextBookFound = Console.ReadLine();

            while(nextBookFound != "No More Books")
            {
                if(nextBookFound == favoriteBook)
                {
                    isBookFound = true;
                    break;
                }
                nextBookFound = Console.ReadLine();
                counter++;
            }
            if(isBookFound)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
