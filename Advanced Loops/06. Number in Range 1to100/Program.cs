using System;

namespace _06._Number_in_Range_1to100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Еnter a number in the range [1...100]:");
            int number = int.Parse(Console.ReadLine());
            while (number<1||number>100)
            {
                Console.WriteLine("Invalid number!");
                Console.WriteLine("Еnter a number in the range [1...100]:");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The number is: {number}");
        }
    }
}
