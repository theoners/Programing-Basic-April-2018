using System;

namespace _10._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int sum = 0;


            for (int i = 0; i < numberCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
                if (number>maxNumber)
                {
                    maxNumber = number;
                }
            }

            if (maxNumber*2==sum )
            {
                Console.WriteLine($"Yes Sum = {maxNumber}");
            }
            else
            {
                Console.WriteLine($"No Diff = {Math.Abs(sum-maxNumber*2)}");
            }
        }
    }
}
