using System;

namespace _06._Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var area = r * r * Math.PI;
            var perimeter = 2 * r * Math.PI;

            Console.WriteLine($"Area = {area}");
            Console.WriteLine($"Perimeter = {perimeter}");
        }
    }
}
