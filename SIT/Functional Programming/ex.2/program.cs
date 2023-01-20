using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int count = numbers.Count();
        Console.WriteLine(count);
        int sum = numbers.Sum();
        Console.WriteLine(sum);
    }
}
