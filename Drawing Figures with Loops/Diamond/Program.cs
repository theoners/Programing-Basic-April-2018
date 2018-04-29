using System;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < (number+1)/2; i++)
            {
                for (int k = 0; k < ((number - 1) / 2)-i; k++)
                {
                    Console.Write('-');
                }

                if (i==0)
                {
                    if (number%2==1)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write("**");
                    }
                    for (int k = 0; k < ((number - 1) / 2) - i; k++)
                    {
                        Console.Write('-');
                    }
                }
                else
                {
                    Console.Write('*');
                    if (number % 2 == 1)
                    {
                        for (int k = 0; k < i*2-1; k++)
                        {
                            Console.Write('-');
                        }
                    }
                    else
                    {
                        for (int k = 0; k < 2*i; k++)
                        {
                            Console.Write('-');
                        }
                    }
                    Console.Write("*");
                    for (int k = 0; k < ((number - 1) / 2) - i; k++)
                    {
                        Console.Write('-');
                    }
                }
                Console.WriteLine();
            }

            for (int i = 0; i < (number - 1) / 2; i++)
            {
                for (int k = 0; k < i+1; k++)
                {
                    Console.Write('-');
                }
                Console.Write('*');

                for (int k = 0; k < (number-4)-i*2; k++)
                {
                    Console.Write('-');
                }
                if (i+1!= (number - 1) / 2)
                {
                    Console.Write('*');
                }
                else
                {
                    if (number%2==1)
                    {
                        
                    }
                    else
                    {
                        Console.Write('*');
                    }
                }
                
                for (int k = 0; k < i + 1; k++)
                {
                    Console.Write('-');
                }
                Console.WriteLine();
            }
        }
    }
}
