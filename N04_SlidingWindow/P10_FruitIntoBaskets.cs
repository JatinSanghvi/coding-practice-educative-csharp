// Fruit Into Baskets
// ==================
//
// While visiting a farm of fruits, you have been given a row of fruits represented by an integer array, `fruits`, where
// `fruits[i]` is the type of fruit the i-th tree produces. You have to collect fruits, but there are some rules that
// you must follow while collecting fruits:
//
// - You are given only two baskets, each capable of holding an unlimited quantity of a single type of fruit.
//
// - You can start collecting from any tree but must collect *exactly one* fruit from each tree (including the
//   starting tree) while moving to the right.
//
// - You must stop while encountering a tree with a fruit type that cannot fit into any of your baskets.
//
// Return the maximum number of fruits you can collect following the above rules for the given array of fruits.
//
// Constraints:
//
// - 1 ≤ `fruits.length` ≤ 10^3
// - 0 ≤ `fruits[i]` < `fruits.length`

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N04_SlidingWindow.P10_FruitIntoBaskets;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public int TotalFruit(int[] fruits)
    {
        int fruit1 = -1, fruit2 = -1;
        int start = 0; // Start index of basket.
        int end1 = -1, end2 = -1; // Last indexes of fruit1 and fruit2 respectively.

        int maxTotal = 0;
        for (int i = 0; i < fruits.Length; i++)
        {
            if (fruits[i] == fruit1)
            {
                end1 = i;
            }
            else if (fruits[i] == fruit2)
            {
                end2 = i;
            }
            else
            {
                if (end1 < end2) // fruit2 was the last fruit. 
                {
                    start = end1 + 1; // Index after which only fruit2 appeared.
                    end1 = i; // Set new fruit as fruit1.
                    fruit1 = fruits[i];
                }
                else
                {
                    start = end2 + 1;
                    end2 = i;
                    fruit2 = fruits[i];
                }
            }

            maxTotal = Math.Max(maxTotal, (i + 1) - start);
        }

        return maxTotal;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(new int[] { 1, 2, 3, 2, 1 }, 3);
        Run(new int[] { 1, 2, 3, 1, 2 }, 2);
        Run(new int[] { 1, 2, 1, 3, 1 }, 3);
    }

    private static void Run(int[] fruits, int expectedResult)
    {
        int result = new Solution().TotalFruit(fruits);
        Utilities.PrintSolution(fruits, result);
        Assert.AreEqual(expectedResult, result);
    }
}
