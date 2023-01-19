using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        List<KeyValuePair<string, int>> nameAgePairs = new List<KeyValuePair<string, int>>();
        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split(',');
            string name = input[0];
            int age = int.Parse(input[1]);
            nameAgePairs.Add(new KeyValuePair<string, int>(name, age));
        }
        string condition = Console.ReadLine();
        int ageInput = int.Parse(Console.ReadLine());
        string format = Console.ReadLine();
        List<KeyValuePair<string, int>> filteredList = new List<KeyValuePair<string, int>>();
        if (condition == "younger")
        {
            filteredList = nameAgePairs.FindAll(x => x.Value < ageInput);
        }
        else if (condition == "older")
        {
            filteredList = nameAgePairs.FindAll(x => x.Value >= ageInput);
        }
        foreach (KeyValuePair<string, int> pair in filteredList)
        {
            if (format == "name")
            {
                Console.WriteLine(pair.Key);
            }
            else if (format == "age")
            {
                Console.WriteLine(pair.Value);
            }
            else if (format == "name age")
            {
                Console.WriteLine(pair.Key + " - " + pair.Value);
            }
        }
    }
}
