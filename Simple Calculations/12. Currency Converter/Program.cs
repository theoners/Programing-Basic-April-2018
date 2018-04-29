using System;

namespace _12._Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = double.Parse(Console.ReadLine());
            var inputCurrency = Console.ReadLine();
            var outputCurrency = Console.ReadLine();
            var exchangeRate = 1.0;

                switch (inputCurrency)
                {
                    case "USD":
                        exchangeRate = 1.79549;
                        break;
                    case "EUR":
                        exchangeRate = 1.95583;
                        break;
                    case "GBP":
                        exchangeRate = 2.53405;
                        break;
                    
                }
            sum = sum * exchangeRate;
            exchangeRate = 1.0;
            switch (outputCurrency)
            {
                case "USD":
                    exchangeRate = 1.79549;
                    break;
                case "EUR":
                    exchangeRate = 1.95583;
                    break;
                case "GBP":
                    exchangeRate = 2.53405;
                    break;

            }
            sum = sum / exchangeRate;

            Console.WriteLine(Math.Round(sum,2));


        }
    }
}
