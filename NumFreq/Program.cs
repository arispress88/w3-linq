using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] numbers = { 5, 9, 1, 5, 5, 9};

        var numberFrequency = numbers.GroupBy(num => num)
                                    .Select(group => new {Number = group.Key, Frequency = group.Count() });
        
        Console.WriteLine("The number and the Frequency are:");

        foreach (var item in numberFrequency)
        {
            Console.WriteLine($"Number {item.Number} appears {item.Frequency}");
        }
    }
}