using System;

namespace _07._2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var sideA = Math.Abs(x1 - x2);
            var sideB = Math.Abs(y1 - y2);

            var area = sideA * sideB;
            var perimeter = sideA * 2 + sideB * 2;

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
