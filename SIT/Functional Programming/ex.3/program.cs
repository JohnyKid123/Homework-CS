using System;

class Program
{
    static void Main(string[] args)
    {
       string input = Console.ReadLine();
        string[] words = input.Split(' ');
        foreach (string word in words)
        {
            if (Char.IsUpper(word[0]))
            {
                Console.WriteLine(word);
            }
        }
    }
}
