using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{

    static Dictionary<char, int> GetCharacterFrequencies(string input)
    {
        return input
            .GroupBy(c => c)
            .ToDictionary(g => g.Key, g => g.Count());
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Dictionary<char, int> frequencies = GetCharacterFrequencies(input);

        Console.WriteLine("The frequency of the characters are:");
        foreach (var kvp in frequencies)
        {
            Console.WriteLine($"Character {kvp.Key}: {kvp.Value} times");
        }
    }
}