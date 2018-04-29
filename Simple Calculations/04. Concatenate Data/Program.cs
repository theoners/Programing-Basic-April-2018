using System;

namespace _04._Concatenate_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            Console.WriteLine($"You are {firstName} {secondName}, a {age}-years old person from {town}.");
        }
    }
}
