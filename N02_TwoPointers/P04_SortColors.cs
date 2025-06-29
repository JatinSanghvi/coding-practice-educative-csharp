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
// - n == `colors.length`
// - 1 ≤ n ≤ 300
// - `colors[i]` is either 0, 1, or 2

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N02_TwoPointers.P04_SortColors;

public class Solution
{
    public static int[] SortColors(int[] colors)
    {
        int zerosRight = 0, onesRight = 0, twosLeft = colors.Length - 1;

        while (onesRight <= twosLeft)
        {
            if (colors[onesRight] == 0) { Swap(zerosRight++, onesRight++); }
            else if (colors[onesRight] == 1) { onesRight++; }
            else if (colors[onesRight] == 2) { Swap(onesRight, twosLeft--); }
        }

        return colors;

        void Swap(int index1, int index2)
        {
            (colors[index2], colors[index1]) = (colors[index1], colors[index2]);
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        CollectionAssert.Equals(new[] { 0, 0, 1, 1, 2, 2 }, Solution.SortColors([0, 1, 2, 0, 1, 2]));
        CollectionAssert.Equals(new[] { 0, 0, 1, 1, 2, 2 }, Solution.SortColors([2, 0, 1, 2, 0, 1]));
        CollectionAssert.Equals(new[] { 0, 0, 1, 1, 2, 2 }, Solution.SortColors([1, 2, 0, 1, 2, 0]));
    }
}
