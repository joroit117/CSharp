using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int overnights = int.Parse(Console.ReadLine());
            double studioPrice = 0.0;
            double apartmentPrice = 0.0;

            switch(month)
            {
                case "May":
                case "October":
                    studioPrice = 50 * overnights;
                    apartmentPrice = 65 * overnights;
                    if(overnights > 14)
                    {
                        studioPrice -= 0.3 * studioPrice;
                    }
                    else if (overnights > 7)
                    {
                        studioPrice -= 0.05 * studioPrice;
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 75.2 * overnights;
                    apartmentPrice = 68.7 * overnights;
                    if (overnights > 14)
                    {
                        studioPrice -= 0.2 * studioPrice;
                    }
                    break;
                case "July":
                case "August":
                    studioPrice = 76 * overnights;
                    apartmentPrice = 77 * overnights;
                    break;
            }
            if(overnights > 14)
            {
                apartmentPrice -= 0.1 * apartmentPrice;
            }
            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
