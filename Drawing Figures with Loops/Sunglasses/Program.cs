using System;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number*2; i++)
            {
                Console.Write("*");
            }

            for (int i = 0; i < number; i++)
            {
                Console.Write(" ");
            }

            for (int i = 0; i < number * 2; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            for (int i = 0; i < number-2; i++)
            {
                Console.Write("*");
                for (int k = 0; k < number*2-2; k++)
                {
                    Console.Write("/");
                }
                Console.Write("*");

                for (int l = 0; l < number; l++)
                {
                    if (i == ((number - 1) / 2 - 1))
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("*");
                for (int k = 0; k < number * 2 - 2; k++)
                {
                    Console.Write("/");
                }
                Console.WriteLine("*");
            }
            for (int i = 0; i < number * 2; i++)
            {
                Console.Write("*");
            }

            for (int i = 0; i < number; i++)
            {
                Console.Write(" ");
            }

            for (int i = 0; i < number * 2; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

        }
    }
}
