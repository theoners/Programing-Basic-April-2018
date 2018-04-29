using System;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number+1; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");

            for (int i = 1; i <= number; i++)
            {
                for (int k = 0; k < number-i; k++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.Write(" | ");

                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
