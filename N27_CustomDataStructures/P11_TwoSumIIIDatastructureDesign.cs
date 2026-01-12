// Two Sum III - Data structure design
// ===================================
//
// Design a data structure that takes in a stream of numbers and can check if any two numbers add up to a specific
// value.
//
// Implement the `TwoSum` class with the following constructor and methods:
//
// - Constructor: Sets up the `TwoSum` object with an empty list at the start.
// - void add(int number): Adds a new number to the list.
// - boolean find(int value): Returns TRUE if any two numbers in the list add up to the given value. If not, it returns
//   FALSE.
//
// Constraints:
//
// - -10^5 ≤ `number` ≤ 10^5
// - -2^31 ≤ `value` ≤ 2^31 - 1
// - At most, 10^4 calls will be made to add and find methods.

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N27_CustomDataStructures.P11_TwoSumIIIDatastructureDesign;

// Space complexity: O(n).
public class TwoSum
{
    private readonly HashSet<int> numbers = new();
    private readonly HashSet<int> duplicates = new();

    // Time complexity: O(1).
    public void Add(int number)
    {
        if (numbers.Contains(number)) { duplicates.Add(number); }
        numbers.Add(number);
    }

    // Time complexity: O(n).
    public bool Find(int value)
    {
        foreach (int number in numbers)
        {
            if (numbers.Contains(value - number) && (number != value - number || duplicates.Contains(number)))
            {
                return true;
            }
        }

        return false;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(["Add 1", "Add 2", "Find 3", "Find 2", "Add 1", "Add 1", "Find 1", "Find 2"], [null, null, true, false, null, null, false, true]);
    }

    private static void Run(string[] operations, bool?[] expectedResults)
    {
        var twoSum = new TwoSum();

        for (int i = 0; i != operations.Length; i++)
        {
            bool? result = null;
            string[] operands = operations[i].Split();

            switch (operands[0])
            {
                case "Add":
                    twoSum.Add(int.Parse(operands[1]));
                    break;
                case "Find":
                    result = twoSum.Find(int.Parse(operands[1]));
                    break;
            }

            Utilities.PrintSolution(operations[i], result);
            Assert.AreEqual(expectedResults[i], result);
        }
    }
}
