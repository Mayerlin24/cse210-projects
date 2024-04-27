using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int userCount = -1; 
        while (userCount != 0)
        {
            Console.WriteLine("Enter a number, type 0 when finished.");
             string userNumber = Console.ReadLine();
             userCount = int.Parse(userNumber);
               
               if (userCount != 0)
            {
                numbers.Add(userCount);
            }
        }
        //Compute the sum, or total, of the numbers in the list
          int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine($"The sum is: {sum}");
        
        //Compute the average of the numbers in the list.
            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");

        //Find the maximum, or largest, number in the list
        int largest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine($"The largest is: {largest}");


    }
}