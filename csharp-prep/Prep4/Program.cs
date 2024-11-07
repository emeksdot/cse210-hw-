using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        List<int> positiveNumbers = new List<int>();

        System.Console.WriteLine("Enter a list of numbers, type 0 (zero) when done ");
        bool key = true;

        while (key)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (num != 0)
            {
                numbers.Add(num);
            }
            else
            {
                break;
            }
        }

        int sumOfNumbers = 0;
        double averageOfNumbers = 0;

        foreach (int number in numbers)
        {
            System.Console.WriteLine(number);
            sumOfNumbers += number;
            averageOfNumbers = Convert.ToDouble(sumOfNumbers) / numbers.Count;
        }

        numbers.Sort();
        foreach (int item in numbers)
        {
            if (item > 0)
            {
                positiveNumbers.Add(item);
            }
        }

        int maxOfNumbers = numbers[numbers.Count - 1];
        System.Console.WriteLine($"The sum of the numbers is: {sumOfNumbers}");
        System.Console.WriteLine($"The average of the numbers is: {averageOfNumbers}");
        System.Console.WriteLine($"The maximum is: {maxOfNumbers}");
        System.Console.WriteLine($"The smallest positive number is: {positiveNumbers[0]}");
    }
}