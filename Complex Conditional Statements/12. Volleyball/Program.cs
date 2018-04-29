using System;

namespace _12._Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            double holidays =double.Parse(Console.ReadLine());
            double weekendsInVillage = double.Parse(Console.ReadLine());

            double weekendsInSofia = (48 - weekendsInVillage) * 3 / 4;
            double holidaysInSofia = holidays * 2 / 3;
            double totalWeekendsInPlay = weekendsInSofia + holidaysInSofia + weekendsInVillage;

            if (yearType =="leap")
            {
                totalWeekendsInPlay += totalWeekendsInPlay * 0.15;
            }

            Console.WriteLine(Math.Floor(totalWeekendsInPlay));


        }
    }
}
