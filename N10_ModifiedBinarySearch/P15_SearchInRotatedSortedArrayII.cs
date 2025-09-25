// Search in Rotated Sorted Array II
// =================================
//
// You are required to find an integer value `target` in an array `arr` of non-distinct integers. Before being passed as
// input to your search function, `arr` has been processed as follows:
//
// - It has been sorted in non-descending order.
// - It has been rotated around some pivot k, such that, after rotation, it looks like this: `[nums[k], nums[k+1], ...,
//   nums[n-1], nums[0], nums[1], ..., nums[k-1]]`. For example, `[10, 30, 40, 42, 42, 47, 78, 90, 901]`, rotated around
//   pivot k = 5 becomes `[47, 78, 90, 901, 10, 30, 40, 42, 42]`.
//
// Return TRUE if `t` exists in the rotated, sorted array `arr`, and FALSE otherwise, while minimizing the number of
// operations in the search.
//
// > Note: In this problem, the value of k is not passed to your search function.
//
// Constraints
//
// - 1 ≤ `arr.length` ≤ 1000
// - -10^4 ≤ `arr[i]` ≤ 10^4
// - `arr` is guaranteed to be rotated at some pivot index.
// - -10^4 ≤ `t` ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N10_ModifiedBinarySearch.P15_SearchInRotatedSortedArrayII;

public class Solution
{
    public static bool Search(int[] arr, int target)
    {
        int low = 0, high = arr.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == target) { return true; }

            if (arr[mid] < arr[high])
            {
                if (arr[mid] < target && target <= arr[high]) { low = mid + 1; }
                else { high = mid - 1; }
            }
            else if (arr[mid] > arr[high])
            {
                if (arr[low] <= target && target < arr[mid]) { high = mid - 1; }
                else { low = mid + 1; }
            }
            else
            {
                high--;
            }
        }

        return false;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 1, 1, 1, 3], 3, true);
        Run([1, 1, 3, 1, 1], 3, true);
        Run([3, 1, 1, 1, 1], 3, true);
        Run([1, 1, 1, 1, 3], 2, false);
        Run([1, 1, 3, 1, 1], 2, false);
        Run([3, 1, 1, 1, 1], 2, false);
    }

    private static void Run(int[] arr, int target, bool expectedResult)
    {
        bool result = Solution.Search(arr, target);
        Utilities.PrintSolution((arr, target), result);
        Assert.AreEqual(expectedResult, result);
    }
}
