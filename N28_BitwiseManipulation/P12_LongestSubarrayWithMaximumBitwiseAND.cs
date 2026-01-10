// Longest Subarray With Maximum Bitwise AND
// =========================================
//
// Given an integer list, `nums`, find the length of the longest subarray where the bitwise AND of its elements equals
// the maximum possible bitwise AND among all subarrays of `nums`. The bitwise AND of a list is calculated by performing
// the bitwise AND operation on all elements within the subarray.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^3
// - 1 ≤ `nums[i]` ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N28_BitwiseManipulation.P12_LongestSubarrayWithMaximumBitwiseAND;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static int LongestSubarray(int[] nums)
    {
        int andTill = 0, andMax = 0;
        int lengthTill = 0, lengthMax = 0;

        foreach (int num in nums)
        {
            if ((andTill & num) >= num)
            {
                andTill &= num;
                lengthTill++;
            }
            else
            {
                andTill = num;
                lengthTill = 1;
            }

            if (andMax < andTill || (andMax == andTill && lengthMax < lengthTill))
            {
                andMax = andTill;
                lengthMax = lengthTill;
            }
        }

        return lengthMax;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 3, 2], 1);
        Run([1, 3, 3, 2], 2);
    }

    private static void Run(int[] nums, int expectedResult)
    {
        int result = Solution.LongestSubarray(nums);
        Utilities.PrintSolution(nums, result);
        Assert.AreEqual(expectedResult, result);
    }
}
