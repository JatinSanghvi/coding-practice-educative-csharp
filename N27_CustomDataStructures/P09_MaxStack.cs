// Max Stack
// =========
//
// Design a custom stack class, Max Stack, that supports the basic stack operations and can find the maximum element
// present in the stack.
//
// Implement the following methods for Max Stack:
//
// - Constructor: This initializes the Max Stack object.
// - Void Push(int x): This pushes the provided element, x, onto the stack.
// - Int Pop( ): This removes and returns the element on the top of the stack.
// - Int Top( ): This retrieves the most recently added element on the top of the stack without removing it.
// - Int peekMax( ): This retrieves the maximum element in the stack without removing it.
// - Int popMax( ): This retrieves the maximum element in the stack and removes it. If there is more than one maximum
//   element, remove the most recently added one (the topmost).
//
// Constraints:
//
// - -1000 ≤ `x` ≤ 1000
// - A maximum of 100 calls can be made to Push( ), Pop( ), Top( ), peekMax( ) and popMax( ).
// - The Pop( ), Top( ), peekMax( ), and popMax( ) methods will always be called on a non-empty stack.

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N27_CustomDataStructures.P09_MaxStack;

// Space complexity: O(n) where n is number of operations.
public class MaxStack
{
    private readonly List<int> stack = new();
    private int stackSize = 0;

    private readonly SortedSet<(int value, int index)> tree = new();
    private readonly HashSet<int> poppedIndexes = new();

    // Time complexity: O(logn).
    public void Push(int x)
    {
        tree.Add((x, stackSize));
        stack.Add(x);
        stackSize++;
    }

    // Time complexity: O(logn) amortized.
    public int Pop()
    {
        int x = stack[^1];
        tree.Remove((x, stackSize - 1));
        stack.RemoveAt(stackSize - 1);
        stackSize--;
        Trim();
        return x;
    }

    // Time complexity: O(1).
    public int Top()
    {
        return stack[^1];
    }

    // Time complexity: O(1).
    public int PeekMax()
    {
        return tree.Max.value;
    }

    // Time complexity: O(logn) amortized.
    public int PopMax()
    {
        (int x, int index) = tree.Max;
        tree.Remove((x, index));
        poppedIndexes.Add(index);
        Trim();
        return x;
    }

    private void Trim()
    {
        while (poppedIndexes.Remove(stackSize - 1))
        {
            stack.RemoveAt(stackSize - 1);
            stackSize--;
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(
            [
                "Push 1", "Push 2", "Push 3", "Push 2", "Push 1", "Top", "PeekMax",
                "PopMax", "Top", "PeekMax", "PopMax", "Top", "PeekMax",
                "Pop", "Top", "PeekMax", "Pop", "Top", "PeekMax", "Pop"
            ],
            [
                null, null, null, null, null, 1, 3,
                3, 1, 2, 2, 1, 2,
                1, 2, 2, 2, 1, 1, 1
            ]);
    }

    private static void Run(string[] operations, int?[] expectedResults)
    {
        var maxStack = new MaxStack();

        for (int i = 0; i != operations.Length; i++)
        {
            int? result = null;
            string[] operands = operations[i].Split();

            switch (operands[0])
            {
                case "Push":
                    maxStack.Push(int.Parse(operands[1]));
                    break;
                case "Pop":
                    result = maxStack.Pop();
                    break;
                case "Top":
                    result = maxStack.Top();
                    break;
                case "PeekMax":
                    result = maxStack.PeekMax();
                    break;
                case "PopMax":
                    result = maxStack.PopMax();
                    break;
            }

            Utilities.PrintSolution(operations[i], result);
            Assert.AreEqual(expectedResults[i], result);
        }
    }
}
