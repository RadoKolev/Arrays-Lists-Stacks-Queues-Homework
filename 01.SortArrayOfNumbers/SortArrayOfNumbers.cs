using System;
using System.Linq;
using System.Runtime.InteropServices;

// Write a program to read an array of numbers from the console, sort them and print them back on the console. The numbers should be entered from the console on a single line, separated by a space. Examples:

// Input                Output 
// 6 5 4 10 -3 120 4    -3 4 4 5 6 10 120
// 10 9 8               8 9 10
class SortArrayOfNumbers
{
    static void Main()
    {
        Console.Write("Please enter numbers on a single line, separated by a space: ");
        string inputNumbers = Console.ReadLine();
        int[] numbers = inputNumbers.Split().Select(int.Parse).ToArray();

        Array.Sort(numbers);

        foreach (var outputNumbers in numbers)
        {
            Console.Write(outputNumbers + " ");   
        }
        Console.WriteLine();
    }
}