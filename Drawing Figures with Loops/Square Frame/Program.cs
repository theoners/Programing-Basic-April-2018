using System;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.Write("+ ");
            for (int i = 0; i < number-2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine('+');

            for (int i = 0; i < number-2; i++)
            {
                Console.Write("| ");
                for (int k = 0; k < number-2; k++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("|");
            }

            Console.Write("+ ");
            for (int i = 0; i < number - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine('+');
        }
    }
}
