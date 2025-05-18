using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<float> numbers = new List<float>();

        float number = -1;
        float sum = 0;
        float largest = 0;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = float.Parse(Console.ReadLine());
            numbers.Add(number);
            sum += number;
            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum / (numbers.Count - 1)}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}