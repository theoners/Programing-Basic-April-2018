using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double result = 0;

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                result = side*side;
            }
            else if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                result = sideA*sideB;
            }
            else if (figure== "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                result = Math.PI * radius * radius;
            }
            else if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                result = (side * height) / 2;
            }
            Console.WriteLine($"{result:F3}");
        }
    }
}
