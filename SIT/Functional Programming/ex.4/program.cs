using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double vat = 0.2; 
        var input = Console.ReadLine();
        var prices = input.Split(',').Select(x => Double.Parse(x)).ToArray();

        foreach (double price in prices)
        {
            double priceWithVat = price + price * vat;
            Console.WriteLine($"{priceWithVat:f2}");
        }
    }
}
