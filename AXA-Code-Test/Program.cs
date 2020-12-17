using AXA_Code_Test.Classes;
using AXA_Code_Test.Interfaces;
using AXA_Code_Test.Repository;
using System;

namespace AXA_Code_Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Insert Search Term...");

            string searchTerm = Console.ReadLine();

            ICityRepository cityRepo = new CityRepository();
            ICityFinder cityFinder = new CityFinder(cityRepo);

            ICityResult cityResult = cityFinder.Search(searchTerm);

            int cityCount = cityResult.NextCities.Count;
            int characterCount = cityResult.NextLetters.Count;

            Console.WriteLine($"Given Search Term {searchTerm}");
            Console.WriteLine($"Found {cityCount} Cities.");
            if (cityCount > 0)
            {
                foreach(string city in cityResult.NextCities)
                {
                    Console.WriteLine($"{city}");
                }
            };
            Console.WriteLine();
            Console.WriteLine($"Found {characterCount} Characters.");
            if (characterCount > 0)
            {
                foreach (string letter in cityResult.NextLetters)
                {
                    Console.WriteLine($"{letter}");
                }
            }
            Console.WriteLine("Finished Search.");

        }
    }
}
