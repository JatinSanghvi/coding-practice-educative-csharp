// Max Stack
// =========
//
// Design a custom stack class, Max Stack, that supports the basic stack operations and can find the maximum element
// present in the stack.
//
// Implement the following methods for Max Stack:
//
// - Constructor: This initializes the Max Stack object.
//
// - Void Push(int x): This pushes the provided element, x, onto the stack.
//
// - Int Pop( ): This removes and returns the element on the top of the stack.
//
// - Int Top( ): This retrieves the most recently added element on the top of the stack without removing it.
//
// - Int peekMax( ): This retrieves the maximum element in the stack without removing it.
//
// - Int popMax( ): This retrieves the maximum element in the stack and removes it. If there is more than one maximum
//   element, remove the most recently added one (the topmost).
//
// Constraints:
//
// - -1000 ≤ `x` ≤ 1000
// - A maximum of 100 calls can be made to Push( ), Pop( ), Top( ), peekMax( ) and popMax( ).
// - The Pop( ), Top( ), peekMax( ), and popMax( ) methods will always be called on a non-empty stack.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N27_CustomDataStructures.P09_MaxStack;

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
