using System;

namespace _05._Trapeziod_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var area = (a + b) * h / 2;
            Console.WriteLine(area);
        }
    }
}
