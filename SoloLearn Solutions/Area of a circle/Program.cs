using System;

namespace Area_of_a_circle
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double radius;

            radius = Convert.ToDouble(Console.ReadLine());

            double area = pi * radius * radius;

            Console.WriteLine(area);
        }
    }
}
