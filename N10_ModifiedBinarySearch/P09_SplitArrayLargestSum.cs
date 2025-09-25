// Split Array Largest Sum
// =======================
//
// Given an integer list `nums` and an integer `k`, split `nums` into `k` non-empty subarrays such that the largest sum
// among these subarrays is minimized. The task is to find the minimized largest sum by choosing the split such that the
// largest sum of every split of subarrays is the minimum among the sum of other splits.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^3
// - 0 ≤ `nums[i]` ≤ 10^4
// - 1 ≤ `k` ≤ `nums.length`

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N10_ModifiedBinarySearch.P09_SplitArrayLargestSum;

// Time complexity: O(n*log(maxValue)), Space complexity: O(1).
public class Solution
{
    public int SplitArray(int[] nums, int k)
    {
        int cannotSplitMax = -1, canSplitMin = int.MaxValue;

        while (cannotSplitMax + 1 != canSplitMin)
        {
            int mid = (cannotSplitMax + canSplitMin) / 2;

            if (CanSplit(mid)) { canSplitMin = mid; }
            else { cannotSplitMax = mid; }
        }

        return canSplitMin;

        bool CanSplit(int value)
        {
            int splits = 1;
            int sum = 0;

            for (int i = 0; i != nums.Length;)
            {
                if (nums[i] > value) { return false; }

                sum += nums[i];
                if (sum <= value)
                {
                    i++;
                }
                else
                {
                    splits++;
                    sum = 0;

                    if (splits > k) { return false; }
                }
            }

            return true;
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 3, 4, 5], 1, 15);
        Run([1, 2, 3, 4, 5], 3, 6);
        Run([1, 2, 3, 4, 5], 5, 5);
        Run([2, 2, 2, 2, 2], 3, 4);
        Run([2, 2, 2, 2, 2], 2, 6);
    }

    private static void Run(int[] nums, int k, int expectedResult)
    {
        int result = new Solution().SplitArray(nums, k);
        Utilities.PrintSolution((nums, k), result);
        Assert.AreEqual(expectedResult, result);
    }
}
