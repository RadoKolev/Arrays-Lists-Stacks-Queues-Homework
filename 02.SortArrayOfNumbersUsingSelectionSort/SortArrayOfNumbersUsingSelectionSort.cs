using System;
using System.Linq;

// Write a program to sort an array of numbers and then print them back on the console. The numbers should be entered from the console on a single line, separated by a space. Refer to the examples for problem 1.

// Note: Do not use the built-in sorting method, you should write your own.
class SortArrayOfNumbersUsingSelectionSort
{
    static void Main()
    {
        Console.Write("Please enter numbers on a single line, separated by a space: ");
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int index = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int min = numbers[i];

            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] < min)
                {
                    min = numbers[j];
                    index = j;
                }
            }
            if (min < numbers[i])
            {
                int temp = numbers[i];
                numbers[i] = min;
                numbers[index] = temp;
            }
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}