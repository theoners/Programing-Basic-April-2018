using System;

namespace _13._Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x>0 && x<3*height && y>0 && y<height)
            {
                Console.WriteLine("inside");
            }
            else if (x > height && x < 2 * height && y > height && y < 4*height)
            {
                Console.WriteLine("inside");
            }
            else if (x>height && x<2*height && y  == height)
            {
                Console.WriteLine("inside");
            }
            else if (x<0 || x>3*height || y <0 || y > 4*height)
            {
                Console.WriteLine("outside");
            }
            else if ((x<height || x>2*height)&& y>height)
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}
