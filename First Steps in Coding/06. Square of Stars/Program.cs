using System;

namespace _06._Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            firstAndLastRowPrint(number);
            MiddleRow(number);
            firstAndLastRowPrint(number);
        }

        private static void MiddleRow(int number)
        {
            for (int i = 0; i < number-2; i++)
            {
                Console.Write('*');
                for (int j = 0; j < number - 2; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine('*');
            }
        }

        static void firstAndLastRowPrint(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write('*');
                
            }
            Console.WriteLine();
        }
    }
}
