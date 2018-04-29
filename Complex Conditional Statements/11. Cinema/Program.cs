using System;

namespace _11._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rowPlace = int.Parse(Console.ReadLine());
            int colPlace = int.Parse(Console.ReadLine());
            double ticketPrice = 0;

            switch (projectionType)
            {
                case "Premiere":
                    ticketPrice = 12;
                    break;
                case "Normal":
                    ticketPrice = 7.50;
                    break;
                case "Discount":
                    ticketPrice = 5;
                    break;
            }

            double income = rowPlace * colPlace * ticketPrice;

            Console.WriteLine($"{income:F2} leva");
        }
    }
}
