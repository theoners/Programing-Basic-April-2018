using System;

namespace Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int row = 0; row < number; row++)
            {
                for (int col = 0; col < number-1; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine('*');
            }
        }
    }
}
