// Largest Rectangle in Histogram
// ==============================
//
// Given an array of integers, `heights`, that represents the heights of bars in a histogram, find the area of the
// largest rectangle in the histogram, where the rectangle has a constant width of 1 unit for each bar.
//
// Constraints
//
// - 1 ≤ `heights.length` ≤ 10^5
// - 0 ≤ `heights[i]` ≤ 10^4

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P11_LargestRectangleInHistogram;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(n).
    public static int LargestRectangle(int[] heights)
    {
        // Use stack to track the last index of height less than the current height.
        var stack = new Stack<int>();
        var starts = new int[heights.Length];
        var ends = new int[heights.Length];

        for (int i = 0; i != heights.Length; i++)
        {
            while (stack.Count != 0 && heights[stack.Peek()] >= heights[i])
            {
                stack.Pop();
            }

            starts[i] = stack.Count == 0 ? 0 : stack.Peek() + 1;
            stack.Push(i);
        }

        stack = new Stack<int>();
        for (int i = heights.Length - 1; i != -1; i--)
        {
            while (stack.Count != 0 && heights[stack.Peek()] >= heights[i])
            {
                stack.Pop();
            }

            ends[i] = stack.Count == 0 ? heights.Length : stack.Peek();
            stack.Push(i);
        }

        int area = 0;
        for (int i = 0; i != heights.Length; i++)
        {
            area = Math.Max(area, heights[i] * (ends[i] - starts[i]));
        }

        return area;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 3, 2, 1], 6);
        Run([1, 2, 3, 4, 5], 9);
    }

    private static void Run(int[] heights, int expectedResult)
    {
        int result = Solution.LargestRectangle(heights);
        Utilities.PrintSolution(heights, result);
        Assert.AreEqual(expectedResult, result);
    }
}
