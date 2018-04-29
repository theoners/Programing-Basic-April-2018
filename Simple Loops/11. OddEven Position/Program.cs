using System;

namespace _11._OddEven_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 0; i < numberCount; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    oddSum += number;
                    if (number>oddMax)
                    {
                        oddMax = number;
                    }
                    if (number<oddMin)
                    {
                        oddMin = number;
                    }
                }
                else
                {
                    evenSum += number;
                    if (number > evenMax)
                    {
                        evenMax = number;
                    }
                    if (number < evenMin)
                    {
                        evenMin = number;
                    }
                }
            }
            if (numberCount>1)
            {
                Console.WriteLine($"oddsum {oddSum} oddmin {oddMin} oddmax {oddMax}" +
                              $" evensum {evenSum} evenmin {evenMin} evenmax {evenMax}");
            }
            else if(numberCount==1)
            {
                Console.WriteLine($"oddsum {oddSum} oddmin {oddMin} oddmax {oddMax}" +
                              $" evensum {evenSum} evenmin no evenmax no");
            }
            else
            {
                Console.WriteLine($"oddsum {oddSum} oddmin no oddmax no" +
                              $" evensum {evenSum} evenmin no evenmax no");
            }
            
        }
    }
}
