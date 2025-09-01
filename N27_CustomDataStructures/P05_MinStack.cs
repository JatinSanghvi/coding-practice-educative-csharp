// Min Stack
// =========
//
// Design a custom stack class, Min Stack, allowing us to push, pop, and retrieve the minimum value in constant time.
// Implement the following methods for Min Stack:
//
// - Constructor: This initializes the Min Stack object.
//
// - Pop(): This removes and returns from the stack the value that was most recently pushed onto it.
//
// - Push(): This pushes the provided value onto the stack.
//
// - Min Number(): This returns the minimum value in the stack in O(1) time.
//
// > Note: The time complexity of all the methods above should be O(1).
//
// Constraints:
//
// - -10^4 ≤ value ≤ 10^4
// - The Pop() and Min Number() methods will always be called on non-empty stacks.
// - At most, 10^3 calls will be made to Push(), Pop(), and Min Number().

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N27_CustomDataStructures.P05_MinStack;

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
