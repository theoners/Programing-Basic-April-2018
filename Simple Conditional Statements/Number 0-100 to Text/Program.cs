using System;

namespace Number_0_100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0 || number > 100)
            {
                Console.WriteLine("invalid number");
            }
            else if (number == 100)
            {
                Console.WriteLine("one hundred");
            }
            else if (number == 0)
            {
                Console.WriteLine("zero");
            }
            else if (number == 1)
            {
                Console.WriteLine("one");
            }
            else if (number == 2)
            {
                Console.WriteLine("two");
            }
            else if (number == 3)
            {
                Console.WriteLine("three");
            }
            else if (number == 4)
            {
                Console.WriteLine("four");
            }
            else if (number == 5)
            {
                Console.WriteLine("five");
            }
            else if (number == 6)
            {
                Console.WriteLine("six");
            }
            else if (number == 7)
            {
                Console.WriteLine("seven");
            }
            else if (number == 8)
            {
                Console.WriteLine("eight");
            }
            else if (number == 9)
            {
                Console.WriteLine("nine");
            }
            else if (number == 10)
            {
                Console.WriteLine("ten");
            }
            else if (number == 11)
            {
                Console.WriteLine("eleven");
            }
            else if (number == 12)
            {
                Console.WriteLine("twelve");
            }
            else if (number == 13)
            {
                Console.WriteLine("thirteen");
            }
            else if (number == 14)
            {
                Console.WriteLine("fourteen");
            }
            else if (number == 15)
            {
                Console.WriteLine("fifteen");
            }
            else if (number == 16)
            {
                Console.WriteLine("sixteen");
            }
            else if (number == 17)
            {
                Console.WriteLine("seventeen");
            }
            else if (number == 18)
            {
                Console.WriteLine("eighteen");
            }
            else if (number == 19)
            {
                Console.WriteLine("nineteen");
            }

            else
            {
                if (number / 10 == 2)
                {
                    Console.Write("twenty");
                }
                else if (number / 10 == 3)
                {
                    Console.Write("thirty");
                }
                else if (number / 10 == 4)
                {
                    Console.Write("forty");
                }
                else if (number / 10 == 5)
                {
                    Console.Write("fifty");
                }
                else if (number / 10 == 6)
                {
                    Console.Write("sixty");
                }
                else if (number / 10 == 7)
                {
                    Console.Write("seventy");
                }
                else if (number / 10 == 8)
                {
                    Console.Write("eighty");
                }
                else if (number / 10 == 9)
                {
                    Console.Write("ninety");
                }
                if (number % 10 == 1)
                {
                    Console.WriteLine(" one");
                }
                else if (number % 10 == 2)
                {
                    Console.WriteLine(" two");
                }
                else if (number % 10 == 3)
                {
                    Console.WriteLine(" three");
                }
                else if (number % 10 == 4)
                {
                    Console.WriteLine(" four");
                }
                else if (number % 10 == 5)
                {
                    Console.WriteLine(" five");
                }
                else if (number % 10 == 6)
                {
                    Console.WriteLine(" six");
                }
                else if (number % 10 == 7)
                {
                    Console.WriteLine(" seven");
                }
                else if (number % 10 == 8)
                {
                    Console.WriteLine(" eight");
                }
                else if (number % 10 == 9)
                {
                    Console.WriteLine(" nine");
                }
            }
        }
    }
}
