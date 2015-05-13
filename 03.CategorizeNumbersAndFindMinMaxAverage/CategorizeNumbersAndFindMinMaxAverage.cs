using System;
using System.Collections.Generic;
using System.Linq;

// Write a program that reads N floating-point numbers from the console. Your task is to separate them in two sets, one containing only the round numbers (e.g. 1, 1.00, etc.) and the other containing the floating-point numbers with non-zero fraction. Print both arrays along with their minimum, maximum, sum and average (rounded to two decimal places). Examples:

// Input                              Output 

// 1.2 -4 5.00 12211 93.003 4 2.2     [1.2, 93.003, 2.2] -> min: 1.2, max: 93.003, sum:
//                                    96.403, avg: 32.13
//                                    [-4, 5, 12211, 4] - > min: -4, max: 12211, sum:
//                                    12216, avg: 3054.00
class CategorizeNumbersAndFindMinMaxAverage
{
    static void Main()
    {
        Console.Write("Please enter numbers on a single line, separated by a space: ");
        double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        List<double> roundNumbers = new List<double>();
        List<double> floatNumbers = new List<double>();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 1 !=0)
            {
                floatNumbers.Add(numbers[i]);
            }
            else
            {
                roundNumbers.Add(numbers[i]);
            }
        }
        Console.WriteLine("[" + string.Join(", ", floatNumbers) +"] -> min: {0}, max {1}, sum: {2}, avg: {3:F2}", floatNumbers.Min(), floatNumbers.Max(), floatNumbers.Sum(), floatNumbers.Average());

        Console.WriteLine("[" + string.Join(", ", roundNumbers) + "] -> min: {0}, max {1}, sum: {2}, avg: {3:F2}", roundNumbers.Min(), roundNumbers.Max(), roundNumbers.Sum(), roundNumbers.Average());
    }
}