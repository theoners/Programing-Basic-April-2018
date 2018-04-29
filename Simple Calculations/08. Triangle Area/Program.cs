using System;

namespace _08._Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());

            var area = side * hight / 2;

            Console.WriteLine(Math.Round(area,2));
        }
    }
}
