// Range Module
// ============
//
// Design a Range Module data structure that effectively tracks ranges of numbers using half-open intervals and allows
// querying these ranges. A half-open interval [left, right) includes all real numbers n where left ≤ n < right.
//
// Implement the RangeModule class with the following specifications:
//
// - Constructor(): Initializes a new instance of the data structure.
//
// - AddRange(): Adds the half-open interval [left, right) to the ranges being tracked. If the interval overlaps with
//   existing ranges, it should add only the numbers within [left, right) that are *not* already being tracked.
//
// - Query Range(): Returns true if every real number within the interval [left, right) is currently being tracked, and
//   false otherwise.
//
// - Remove Range(): Removes tracking for every real number within the half-open interval [left, right).
//
// Constraints:
//
// - 1 ≤ `left` < `right` ≤ 10^4
// - At most, 10^3 calls will be made to AddRange(), Query Range(), and Remove Range().

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N27_CustomDataStructures.P06_RangeModule;

// Space complexity: O(n) where n is number of 'add range' and 'remove range' operations.
public class RangeModule
{
    private record Range(int Left, int Right);
    private readonly LinkedList<Range> ranges = new([new Range(-1, -1), new Range(10001, 10001)]);

    // Time complexity: O(n).
    public void AddRange(int left, int right)
    {
        LinkedListNode<Range> node;
        for (node = ranges.First; node.Value.Right < left; node = node.Next) ;

        ranges.AddBefore(node, new Range(left, right));
        node = node.Previous;

        while (node.Next.Value.Left <= right)
        {
            node.Value = new Range(
                Math.Min(node.Value.Left, node.Next.Value.Left),
                Math.Max(node.Value.Right, node.Next.Value.Right));

            ranges.Remove(node.Next);
        }
    }

    // Time complexity: O(n).
    public void RemoveRange(int left, int right)
    {
        LinkedListNode<Range> node;
        for (node = ranges.First; node.Value.Right <= left; node = node.Next) ;

        if (node.Value.Left < left)
        {
            int nodeRight = node.Value.Right;
            node.Value = new Range(node.Value.Left, left);
            ranges.AddAfter(node, new Range(left, nodeRight));
            node = node.Next;
        }

        while (node.Value.Right <= right)
        {
            LinkedListNode<Range> nextNode = node.Next;
            ranges.Remove(node);
            node = nextNode;
        }

        node.Value = new Range(Math.Max(node.Value.Left, right), node.Value.Right);
    }

    // Time complexity: O(n).
    public bool QueryRange(int left, int right)
    {
        LinkedListNode<Range> node;
        for (node = ranges.First; node.Value.Right <= left; node = node.Next) ;
        return node.Value.Left <= left && node.Value.Right >= right;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(
            [
                "AddRange 1 2", "AddRange 3 4", "AddRange 5 6", "QueryRange 4 5",
                 "AddRange 7 8", "AddRange 2 3", "AddRange 4 7", "QueryRange 4 5",
                "RemoveRange 1 2", "RemoveRange 3 4", "RemoveRange 5 6", "QueryRange 4 5",
                "RemoveRange 7 8", "RemoveRange 2 3", "RemoveRange 4 7", "QueryRange 4 5",
            ],
            [null, null, null, false, null, null, null, true, null, null, null, true, null, null, null, false]);
    }

    private static void Run(string[] operations, bool?[] expectedResults)
    {
        var rangeModule = new RangeModule();

        for (int i = 0; i != operations.Length; i++)
        {
            bool? result = null;
            string[] operands = operations[i].Split();

            switch (operands[0])
            {
                case "AddRange":
                    rangeModule.AddRange(int.Parse(operands[1]), int.Parse(operands[2]));
                    break;
                case "RemoveRange":
                    rangeModule.RemoveRange(int.Parse(operands[1]), int.Parse(operands[2]));
                    break;
                case "QueryRange":
                    result = rangeModule.QueryRange(int.Parse(operands[1]), int.Parse(operands[2]));
                    break;
            }

            Utilities.PrintSolution(operations[i], result);
            Assert.AreEqual(expectedResults[i], result);
        }
    }
}
