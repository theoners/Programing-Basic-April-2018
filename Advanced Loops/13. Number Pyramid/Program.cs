using System;

namespace _13._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int number = 1;

            for (int i = 1; i <= numberCount; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write(number+" ");
                    if (number==numberCount)
                    {
                        return;
                    }
                    number++;
                }
                Console.WriteLine();
            }
        }
    }
}
