using System;

namespace _12._Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int f0 = 1;
            int f1 = 1;
            
            if (number<2)
            {
                Console.WriteLine(1);
            }
            else
            {
                int f2=0;
                for (int i = 1; i < number; i++)
                {
                    f2 = f0 + f1;
                    f0 = f1;
                    f1 = f2;
                }
                Console.WriteLine(f2);
            }
        }
    }
}
