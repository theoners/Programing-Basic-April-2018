using System;

namespace _11._Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isNumber = int.TryParse(Console.ReadLine(), out int number);

            while (true)
            {
                if (isNumber)
                {
                    if (number%2==0)
                    {
                        Console.WriteLine($"Even number entered: {number}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The number is not even.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }

                isNumber = int.TryParse(Console.ReadLine(), out  number);
            }
        }
    }
}
