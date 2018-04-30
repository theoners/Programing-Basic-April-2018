using System;

namespace _14._Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                for (int k = i; k <= number; k++)
                {
                    Console.Write(k+" ");
                }
                for (int k = 1; k < i; k++)
                {
                    Console.Write((number-k)+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
