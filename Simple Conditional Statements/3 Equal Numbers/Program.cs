using System;

namespace _3_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            if (firstNumber==secondNumber && firstNumber==thirdNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
