using System;

namespace _12._Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            double sum = 0;
            double diff = 0;
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double previousSum = firstNumber+secondNumber;

            for (int i = 0; i < numberCount-1; i++)
            {
                firstNumber = double.Parse(Console.ReadLine());
                secondNumber = double.Parse(Console.ReadLine());
                sum = firstNumber + secondNumber;

                diff = Math.Abs(sum-previousSum);
                previousSum = sum;

            }
            if (diff==0)
            {
                Console.WriteLine($"Yes, value={previousSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={diff}");
            }
        }
    }
}
