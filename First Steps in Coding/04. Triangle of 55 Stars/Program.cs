using System;

namespace _04._Triangle_of_55_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k <=i; k++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
