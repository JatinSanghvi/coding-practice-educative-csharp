// Find Minimum in Rotated Sorted Array
// ====================================
//
// You're given a rotated sorted array, `arr`, of length n, that is rotated clockwise between 1 and n times.
//
// For example,
//
// - Before rotation, `arr` = [1,2,3,4,5,6,7,8]
// - After 3 rotations, the array becomes [6,7,8,1,2,3,4,5].
//
// Mathematically, we can say that if the original array was [a[0],a[1],a[2],...,a[n-1]], then each rotation changes the
// array as follows:
//
// - First rotation: [a[n-1],a[0],a[1],a[2],...,a[n-2]]
// - Second rotation: [a[n-2],a[n-1],a[0],a[1],a[2],...,a[n-3]]
// - Third rotation: [a[n-3],a[n-2],a[n-1],a[0],a[1],a[2],...,a[n-4]]
//
// In the example above, the minimum element is 1 at index 3.
//
// For the given array, your task is to find the minimum element of this array.
//
// Constraints:
//
// - n == `arr.length`
// - 1 ≤ n ≤ 1000
// - -5000 ≤ `arr[i]` ≤ 5000
// - All the elements of the array are distinct, that is, there are no duplicate elements.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P08_FindMinimumInRotatedSortedArray;

public class Solution
{
    // Time complexity: O(logn), Space complexity: O(1).
    public static int FindMin(int[] arr)
    {
        int low = 0, high = arr.Length;

        while (high - low != 1)
        {
            int mid = (low + high) / 2;

            if (arr[mid - 1] < arr[high - 1]) { high = mid; }
            else { low = mid; }
        }

        return arr[low];
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 3], 1);
        Run([3, 1, 2], 1);
        Run([2, 3, 1], 1);
    }

    private static void Run(int[] arr, int expectedResult)
    {
        int result = Solution.FindMin(arr);
        Utilities.PrintSolution(arr, result);
        Assert.AreEqual(expectedResult, result);
    }
}
