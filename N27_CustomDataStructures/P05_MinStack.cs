// Min Stack
// =========
//
// Design a custom stack class, Min Stack, allowing us to push, pop, and retrieve the minimum value in constant time.
// Implement the following methods for Min Stack:
//
// - Constructor: This initializes the Min Stack object.
// - Pop(): This removes and returns from the stack the value that was most recently pushed onto it.
// - Push(): This pushes the provided value onto the stack.
// - Min Number(): This returns the minimum value in the stack in O(1) time.
//
// > Note: The time complexity of all the methods above should be O(1).
//
// Constraints:
//
// - -10^4 ≤ value ≤ 10^4
// - The Pop() and Min Number() methods will always be called on non-empty stacks.
// - At most, 10^3 calls will be made to Push(), Pop(), and Min Number().

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N27_CustomDataStructures.P05_MinStack;

// Space complexity: O(n) where n is number of push operations.
public class MinStack
{
    private readonly Stack<int> stack = new();
    private readonly Stack<int> minStack = new();

    // Time complexity: O(1).
    public int Pop()
    {
        int value = stack.Pop();

        if (minStack.Peek() == value)
        {
            minStack.Pop();
        }

        return value;
    }

    // Time complexity: O(1).
    public void Push(int value)
    {
        stack.Push(value);

        if (minStack.Count == 0 || minStack.Peek() >= value)
        {
            minStack.Push(value);
        }
    }

    // Time complexity: O(1).
    public int MinNumber()
    {
        return minStack.Peek();
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(
            ["Push 2", "Push 1", "MinNumber", "Push 1", "Pop", "Pop", "MinNumber", "Pop"],
            [null, null, 1, null, 1, 1, 2, 2]);
    }

    private static void Run(string[] operations, int?[] expectedResults)
    {
        var minStack = new MinStack();

        for (int i = 0; i != operations.Length; i++)
        {
            int? result = null;
            string[] operands = operations[i].Split();
            switch (operands[0])
            {
                case "Pop":
                    result = minStack.Pop();
                    break;
                case "Push":
                    minStack.Push(int.Parse(operands[1]));
                    break;
                case "MinNumber":
                    result = minStack.MinNumber();
                    break;
            }

            Utilities.PrintSolution(operations[i], result);
            Assert.AreEqual(expectedResults[i], result);
        }
    }
}
