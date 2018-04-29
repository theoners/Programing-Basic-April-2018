using System;

namespace Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int row = 0; row < number; row++)
            {
                for (int col = 0; col < row; col++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine("$");
            }
        }
    }
}
