using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = {5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2};

        var result = numbers
            .GroupBy(n => n)
            .Select(g => new
            {
                Number = g.Key,
                Frequency = g.Count(),
                Multiplication = g.Key * g.Count()
            });

        Console.WriteLine("Number | Frequency | Multiplication");
        foreach (var item in result)
        {
            Console.WriteLine($"{item.Number, -7} | {item.Frequency, -9} | {item.Multiplication}");
        }

        Console.ReadLine();
    }
}