using System;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (minutes<45)
            {
                Console.WriteLine($"{hours}:{minutes+15}");
            }
            else if (hours!=23)
            {
                Console.WriteLine($"{hours+1}:{(minutes-45):D2}");
            }
            else
            {
                Console.WriteLine($"0:{(minutes-45):D2}");
            }
        }
    }
}
