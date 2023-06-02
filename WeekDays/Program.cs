using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        string[] daysOfWeek = Enum.GetValues(typeof(DayOfWeek))
                                .Cast<DayOfWeek>()
                                .Select(d => d.ToString())
                                .ToArray();

        Console.WriteLine("Days of the Week:");
        foreach (string day in daysOfWeek)
        {
            Console.WriteLine(day);
        }

        Console.ReadLine();
    }
}