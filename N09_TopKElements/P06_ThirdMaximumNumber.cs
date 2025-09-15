// Third Maximum Number
// ====================
//
// For a given integer array `nums`, your task is to return the third maximum distinct number in the array. If there are
// fewer than three distinct numbers, return the maximum number.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^3
// - -2^31 ≤ `nums[i]` ≤ 2^31 - 1

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P06_ThirdMaximumNumber;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static int ThirdMax(int[] nums)
    {
        // A non heap-based solution, just for fun!
        int max1 = int.MinValue;
        int max2 = int.MinValue;
        int max3 = int.MinValue;

        foreach (int num in nums)
        {
            if (num == max1 || num == max2 || num == max3) { continue; }

            if (num > max1) { (max1, max2, max3) = (num, max1, max2); }
            else if (num > max2) { (max2, max3) = (num, max2); }
            else if (num > max3) { max3 = num; }
        }

        return max3 != int.MinValue ? max3 : max1;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 3, 4, 1, 2, 3, 4], 2);
    }

    private static void Run(int[] nums, int expectedResult)
    {
        int result = Solution.ThirdMax(nums);
        Utilities.PrintSolution(nums, result);
        Assert.AreEqual(expectedResult, result);
    }
}
