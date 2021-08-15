using System;

namespace Level_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int levels = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Points(levels));
        }


        static int Points(int levels)
        {
            int points = 0;
            for(int i = levels; i > 0; i--)
            {
                points = points + i;
            }

            return points;

        }
    }
}
