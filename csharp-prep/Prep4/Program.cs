using System;

class ListOfNumbers
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number;
        do
        {
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        float average = (float)sum / numbers.Count;

        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        int smallestPositive = numbers[0];
        foreach (int num in numbers)
        {
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            }
        }

        List<int> sortedNumbers = numbers.OrderBy(x => x).ToList();

        Console.WriteLine("The sum is: {0}", sum);
        Console.WriteLine("The average is: {0}", average);
        Console.WriteLine("The largest number is: {0}", max);
        Console.WriteLine("The smallest positive number is: {0}", smallestPositive);
        Console.WriteLine("The sorted list is:");
        foreach (int num in sortedNumbers)
        {
            Console.WriteLine("{0}", num);
        }
    }
}