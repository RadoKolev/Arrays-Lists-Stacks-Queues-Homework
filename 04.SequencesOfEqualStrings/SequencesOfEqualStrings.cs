using System;
using System.Linq;

// Write a program that reads an array of strings and finds in it all sequences of equal elements (comparison should be case-sensitive). The input strings are given as a single line, separated by a space. Examples:

// Input                      Output 

// hi yes yes yes bye         hi
//                            yes yes yes
//                            bye

// SoftUni softUni softuni    SoftUni
//                            softUni
//                            softuni

// 1 1 2 2 3 3 4 4 5 5        1 1
//                            2 2
//                            3 3
//                            4 4
//                            5 5

// a b b xxx c c c            a
//                            b b
//                            xxx
//                            c c c 

// hi hi hi hi hi             hi hi hi hi hi

// hello                      hello
class SequencesOfEqualStrings
{
    static void Main()
    {
        Console.Write("Please enter your strins on a single line, separated by a space: ");
        string[] inputList = Console.ReadLine().Split();

        var list = inputList.GroupBy(a => a);

        foreach (var outputList in list)
        {
            Console.WriteLine(String.Join(" ", outputList)); 
        }
    }
}