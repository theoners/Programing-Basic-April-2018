using System;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPerson = int.Parse(Console.ReadLine());
            int secondPerson = int.Parse(Console.ReadLine());
            int thirdPerson = int.Parse(Console.ReadLine());

            int sumSeconds = firstPerson + secondPerson + thirdPerson;
            int minutes = sumSeconds / 60;
            int seconds = sumSeconds % 60;

            Console.WriteLine($"{minutes}:{seconds:D2}");
        }
    }
}
