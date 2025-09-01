// Two Sum III - Data structure design
// ===================================
//
// Design a data structure that takes in a stream of numbers and can check if any two numbers add up to a specific
// value.
//
// Implement the `TwoSum` class with the following constructor and methods:
//
// - Constructor: Sets up the `TwoSum` object with an empty list at the start.
//
// - void add(int number): Adds a new number to the list.
//
// - boolean find(int value): Returns TRUE if any two numbers in the list add up to the given value. If not, it returns
//   FALSE.
//
// Constraints:
//
// - -10^5 ≤ `number` ≤ 10^5
// - -2^31 ≤ `value` ≤ 2^31 - 1
// - At most, 10^4 calls will be made to add and find methods.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N27_CustomDataStructures.P11_TwoSumIIIDatastructureDesign;

public class Solution
{
    public static bool Function()
    {
        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(true);
    }

    private static void Run(bool expectedResult)
    {
        bool result = Solution.Function();
        Utilities.PrintSolution(true, result);
        Assert.AreEqual(expectedResult, result);
    }
}
