using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] numbers = { 9, 8, 6, 5};

        var result = numbers.Select(num => new { Number = num, SqrNo = num * num });

        foreach (var item in result)
        {
            Console.WriteLine($"{{Number = {item.Number}, SqrNo = {item.SqrNo}}}");
        }
    }
}