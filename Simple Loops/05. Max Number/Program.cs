using System;

namespace _05._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;

            for (int i = 0; i < numberCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number>maxNumber)
                {
                    maxNumber = number;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
