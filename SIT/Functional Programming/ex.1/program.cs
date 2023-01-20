using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int[] numbers = input.Split(',').Select(n => int.Parse(n)).ToArray();
        int[] evenNumbers = numbers.Where(n => n % 2 == 0).ToArray();
        Array.Sort(evenNumbers);
        Console.WriteLine(string.Join(", ", evenNumbers));
    }
}
