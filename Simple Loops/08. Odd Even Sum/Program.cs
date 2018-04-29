using System;

namespace _08._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < numberCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    oddSum += number;
                }
                else
                {
                    evenSum += number;
                }
            }
            if (oddSum==evenSum)
            {
                Console.WriteLine($"Yes Sum = {oddSum}");
            }
            else
            {
                Console.WriteLine($"No Diff = {Math.Abs(oddSum-evenSum)}");
            }
        }
    }
}
