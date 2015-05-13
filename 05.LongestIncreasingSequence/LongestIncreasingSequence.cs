using System;
using System.Linq;

// Write a program to find all increasing sequences inside an array of integers. The integers are given on a single line, separated by a space. Print the sequences in the order of their appearance in the input array, each at a single line. Separate the sequence elements by a space. Find also the longest increasing sequence and print it at the last line. If several sequences have the same longest length, print the left-most of them. Examples:

// Input                   Output 

// 2 3 4 1 50 2 3 4 5      2 3 4
//                         1 50
//                         2 3 4 5
//                         Longest: 2 3 4 5

// 8 9 9 9 -1 5 2 3        8 9
//                         9
//                         9
//                         -1 5
//                         2 3
//                         Longest: 8 9
                      
// 1 2 3 4 5 6 7 8 9       1 2 3 4 5 6 7 8 9
//                         Longest: 1 2 3 4 5 6 7 8 9

// 5 -1 10 20 3 4          5
//                         -1 10 20
//                         3 4
//                         Longest: -1 10 20 

// 10 9 8 7 6 5 4 3 2 1    10
//                         9
//                         8
//                         7
//                         6
//                         5
//                         4
//                         3
//                         2
//                         1
//                         Longest: 10
class LongestIncreasingSequence
{
    static void Main()
    {
        Console.Write("Please enter your integers in a single line, separated by a space: ");
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int count = 1;
        int max = 1;
        int end = 0;

        Console.Write(numbers[0]+ " ");
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > numbers[i - 1])
            {
                count++;
                Console.Write(numbers[i]+ " ");                  
            }
            else
            {
                count = 1;
                Console.WriteLine();
                Console.Write(numbers[i]+ " ");
            }
            if (count > max)
            {
                max = count;
                end = i;
            }
        }
        Console.WriteLine();
        Console.Write("Longest: ");
        for (int j = end - max + 1; j <= end; j++)
        {
            Console.Write(numbers[j]+ " ");
        }
        Console.WriteLine();
    }
}