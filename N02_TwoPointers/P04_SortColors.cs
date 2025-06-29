// Sort Colors
// ===========
// 
// Given an array, `colors`, which contains a combination of the following three elements:
// - 0 (Representing red)
// - 1 (Representing white)
// - 2 (Representing blue)
// 
// Sort the array *in place* so that the elements of the same color are adjacent, and the final order is: red (0), then
// white (1), and then blue (2).
// 
// > Note: You are *not allowed* to use any built-in sorting functions. The goal is to solve this efficiently without
// extra space.
// 
// Constraints:
// 
// - n == `colors.length`
// - 1 ≤ n ≤ 300
// - `colors[i]` is either 0, 1, or 2

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N02_TwoPointers.P04_SortColors;

public class Solution
{
    public static int[] SortColors(int[] colors)
    {
        // Loop invariance:
        // Elements in colors[..redRight] are red.
        // Elements in colors[redRight..whiteRight] are white.
        // Elements in colors[blueLeft..] are blue.

        int redRight = 0;
        int whiteRight = 0;
        int blueLeft = colors.Length;

        while (whiteRight < blueLeft)
        {
            if (colors[whiteRight] == 0)
            {
                Swap(redRight++, whiteRight++);
            }
            else if (colors[whiteRight] == 1)
            {
                whiteRight++;
            }
            else
            {
                Swap(whiteRight, --blueLeft);
            }
        }

        return colors;

        void Swap(int index1, int index2)
        {
            (colors[index1], colors[index2]) = (colors[index2], colors[index1]);
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(new[] { 0, 1, 2, 0, 1, 2 }, new[] { 0, 0, 1, 1, 2, 2 });
        Run(new[] { 2, 0, 1, 2, 0, 1 }, new[] { 0, 0, 1, 1, 2, 2 });
        Run(new[] { 1, 2, 0, 1, 2, 0 }, new[] { 0, 0, 1, 1, 2, 2 });
    }

    private static void Run(int[] colors, int[] expectedResult)
    {
        var colorsCopy = new int[colors.Length];
        Array.Copy(colors, colorsCopy, colors.Length);

        int[] result = Solution.SortColors(colorsCopy);
        Utilities.PrintSolution(colors, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
