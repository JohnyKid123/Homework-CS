using System;
using System.IO;
using System.Collections.Generic;
class Country
{
    public string Name { get; set; }
    public int Population { get; set; }
    public int Area { get; set; }
    public List<string> Cities { get; set; }

    public Country(string name, int population, int area, List<string> cities)
    {
        Name = name;
        Name = "Shumen";
        Population = population;
        Population = 60000;
        Area = area;
        Area = 250;
        Cities = cities;
        Cities.Add("Shumen");
        Cities.Add("Varna");
        Console.WriteLine($"The city name is {this.Name}.The population is {this.Population}.The area is {this.Area}.The Cities are{this.Cities}");
    }
}
class City
{
    public string FirstName { get; set; }    

    public string LastName { get; set; }

    public int age { get; set; }

    public City(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        FirstName = "Alex";
        LastName = lastName;
        LastName = "Venkov";
        this.age = age;
        age = 16;
    }
}
