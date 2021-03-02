using System;

namespace FootballSouvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string typeOfSouvenir = Console.ReadLine();
            int numberOfSouvenirs = int.Parse(Console.ReadLine());

            double pricePerSouvenir = 0;
            bool invalid = false;

            switch (country)
            {
                case "Argentina":
                    switch(typeOfSouvenir)
                    {
                        case "flags":
                            pricePerSouvenir = 3.25;
                            break;
                        case "caps":
                            pricePerSouvenir = 7.2;
                            break;
                        case "posters":
                            pricePerSouvenir = 5.1;
                            break;
                        case "stickers":
                            pricePerSouvenir = 1.25;
                            break;
                        default:
                            Console.WriteLine("Invalid stock!");
                            invalid = true;
                            break;
                    }
                    break;
                case "Brazil":
                    switch (typeOfSouvenir)
                    {
                        case "flags":
                            pricePerSouvenir = 4.2;
                            break;
                        case "caps":
                            pricePerSouvenir = 8.5;
                            break;
                        case "posters":
                            pricePerSouvenir = 5.35;
                            break;
                        case "stickers":
                            pricePerSouvenir = 1.2;
                            break;
                        default:
                            Console.WriteLine("Invalid stock!");
                            invalid = true;
                            break;
                    }
                    break;
                case "Croatia":
                    switch (typeOfSouvenir)
                    {
                        case "flags":
                            pricePerSouvenir = 2.75;
                            break;
                        case "caps":
                            pricePerSouvenir = 6.9;
                            break;
                        case "posters":
                            pricePerSouvenir = 4.95;
                            break;
                        case "stickers":
                            pricePerSouvenir = 1.1;
                            break;
                        default:
                            Console.WriteLine("Invalid stock!");
                            invalid = true;
                            break;
                    }
                    break;
                case "Denmark":
                    switch (typeOfSouvenir)
                    {
                        case "flags":
                            pricePerSouvenir = 3.1;
                            break;
                        case "caps":
                            pricePerSouvenir = 6.5;
                            break;
                        case "posters":
                            pricePerSouvenir = 4.8;
                            break;
                        case "stickers":
                            pricePerSouvenir = 0.9;
                            break;
                        default:
                            Console.WriteLine("Invalid stock!");
                            invalid = true;
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid country!");
                    invalid = true;
                    break;
            }
            if(invalid == false)
            {
                double endPrice = numberOfSouvenirs * pricePerSouvenir;
                Console.WriteLine($"Pepi bought {numberOfSouvenirs} {typeOfSouvenir} of {country} for {endPrice:f2} lv.");
            }

        }
    }
}
