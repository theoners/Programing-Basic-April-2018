using System;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < (number+1)/2; i++)
            {
                for (int k = 0; k < ((number-1)/2)-i; k++)
                {
                    Console.Write('-');
                }
                if (number%2==1)
                {
                    for (int k = 0; k < 1+i*2; k++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (int k = 0; k < 2 + i * 2; k++)
                    {
                        Console.Write("*");
                    }
                }
                for (int k = 0; k < ((number - 1) / 2)-i; k++)
                {
                    Console.Write('-');
                }
                Console.WriteLine();
            }

            for (int i = 0; i < number/2; i++)
            {
                Console.Write("|");

                for (int k = 0; k < number-2; k++)
                {
                    Console.Write('*');
                }
                Console.WriteLine('|');
            }
        }
    }
}
