using System;
using System.Collections.Generic;

namespace Coffee_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            int discount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);


            foreach(string s in coffee.Keys)
            {
                //coffee[s] = coffee[s] - (coffee[s] * (discount/100));
                int price = coffee[s];
                price = price - (price * discount / 100);
                coffee.Add(s, price);
                //Console.WriteLine(price);
                Console.WriteLine(s + ": " + coffee[s]);
            }



        }
    }
}
