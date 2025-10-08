// Find the Distance Value Between Two Arrays
// ==========================================
//
// You are given two integer arrays, `arr1` and `arr2`, along with an integer `d`. Your task is to find and return the
// distance value between these arrays.
//
// > Note: The distance value is defined as the count of elements in `arr1` for which there is no element in `arr2` such
// > that ∣arr1[i] - arr2[j]∣ ≤ `d`.
//
// Constraints:
//
// - 1 ≤ `arr1.length`, `arr2.length` ≤ 500
// - -1000 ≤ `arr1[i]`, `arr2[j]` ≤ 1000
// - 0 ≤ `d` ≤ 100

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N17_SortAndSearch.P01_FindTheDistanceValueBetweenTwoArrays;

public class Solution
{
    // Time complexity: O((m + n)*logn), Space complexity: O(1).
    public static int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
    {
        Array.Sort(arr2);

        int distance = 0;
        foreach (int num in arr1)
        {
            int low = 0, high = arr2.Length;
            while (low != high)
            {
                int mid = (low + high) / 2;
                if (arr2[mid] < num - d) { low = mid + 1; }
                else if (arr2[mid] > num + d) { high = mid; }
                else { break; }
            }

            distance += (low == high) ? 1 : 0;
        }

        return distance;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([-20, -10, 0, 10, 20], [-15, 15], 5, 1);
        Run([-20, -10, 0, 10, 20], [-25, 25], 5, 3);
    }

    private static void Run(int[] arr1, int[] arr2, int d, int expectedResult)
    {
        int result = Solution.FindTheDistanceValue(arr1, arr2, d);
        Utilities.PrintSolution((arr1, arr2, d), result);
        Assert.AreEqual(expectedResult, result);
    }
}
