// Two Sum
// =======
//
// For the given array of integers `arr` and a target `t`, you have to identify the two indices that add up to generate
// the target `t`. Moreover, you can't use the same index twice, and there will be only one solution.
//
// > Note: We will assume that the array is zero-indexed and the output order doesn't matter.
//
// Constraints:
//
// - 2 ≤ `arr.length` ≤ 10^4
// - -10^9 ≤ `arr[i]` ≤ 10^9
// - -10^9 ≤ `t` ≤ 10^9
// - Only one valid answer exists.

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P07_TwoSum;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(n).
    public static int[] TwoSum(int[] arr, int t)
    {
        var indexes = new Dictionary<int, int>();

        for (int i = 0; i != arr.Length; i++)
        {
            if (indexes.TryGetValue(t - arr[i], out int j))
            {
                return new int[] { j, i };
            }

            indexes[arr[i]] = i;
        }

        throw new InvalidOperationException();
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([-1, 0, 2, 4, 8], -1, [0, 1]);
        Run([-1, 0, 2, 4, 8], 3, [0, 3]);
    }

    private static void Run(int[] arr, int t, int[] expectedResult)
    {
        int[] result = Solution.TwoSum(arr, t);
        Utilities.PrintSolution((arr, t), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
