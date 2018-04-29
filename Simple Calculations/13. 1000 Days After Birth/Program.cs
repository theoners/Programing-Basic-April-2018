using System;
using System.Globalization;

namespace _13._1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patern = "dd-MM-yyyy";
            DateTime date = DateTime.ParseExact(input, patern, CultureInfo.InvariantCulture);
            date = date.AddDays(999);
            Console.WriteLine(date.ToString(patern));

        }
    }
}
