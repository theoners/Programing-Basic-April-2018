using System;

namespace _09._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (number!=0)
            {
                int lastdigits = number % 10;
                number = number / 10;
                sum += lastdigits;
            }
            Console.WriteLine(sum);
        }
    }
}
