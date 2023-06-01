using System;
using System.Linq;

public class NumberRange
{
    public static void Main()
    {
        Console.WriteLine("The numbers within the range of 1 to 11 are:");

        // List of numbers (Part 1)
        var numbers = new [] {-2, 1, 3, -4, 6, 9, 10, -1, -3, 5};

        // using two where conditions to find the positive numbers within the given range (Part 2)
        var positiveNumbersInRange = from num in numbers
                                    where num >= 1 && num <= 11
                                    select num;

        // Print the positive numbers within range (Part 3)
        Console.WriteLine(string.Join(" ", positiveNumbersInRange));
    }
}