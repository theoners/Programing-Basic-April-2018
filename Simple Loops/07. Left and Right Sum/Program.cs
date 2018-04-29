using System;

namespace _07._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < numberCount; i++)
            {
                int leftNumber = int.Parse(Console.ReadLine());
                leftSum += leftNumber;

            }
            for (int i = 0; i < numberCount; i++)
            {
                int rightNumber = int.Parse(Console.ReadLine());
                rightSum += rightNumber;
            }
            if (rightSum==leftSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(rightSum-leftSum)}");
            }
        }
    }
}
