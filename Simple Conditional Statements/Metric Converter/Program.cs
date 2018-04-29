using System;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();
            
            double millimeters = 1000;
            double centimeters = 100;
            double miles = 0.000621371192;
            double inches = 39.3700787;
            double kilometers = 0.001;
            double feet = 3.2808399;
            double yards = 1.0936133;

            switch (inputUnit)
            {
                case "mm":
                    distance = distance / millimeters;
                    break;              
                case "cm":              
                    distance = distance / centimeters;
                    break;              
                case "mi":              
                    distance = distance / miles;
                    break;              
                case "in":              
                    distance = distance / inches;
                    break;              
                case "km":              
                    distance = distance / kilometers;
                    break;              
                case "ft":              
                    distance = distance / feet;
                    break;
                case "yd":
                    distance = distance / yards;
                    break;
                
            }
            switch (outputUnit)
            {
                case "mm":
                    distance = distance * millimeters;
                    break;
                case "cm":
                    distance = distance * centimeters;
                    break;
                case "mi":
                    distance = distance * miles;
                    break;
                case "in":
                    distance = distance * inches;
                    break;
                case "km":
                    distance = distance * kilometers;
                    break;
                case "ft":
                    distance = distance * feet;
                    break;
                case "yd":
                    distance = distance * yards;
                    break;

            }
            Console.WriteLine($"{distance:F8}");
        }
    }
}
