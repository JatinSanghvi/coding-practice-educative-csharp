// Majority Element
// ================
//
// Given an array, `nums`, having n integers, return the majority element. An element will be considered a majority
// element if it occurs more than ⌊n/2⌋ times in the array.
//
// > Note: It is safe to assume that the majority element always exists in the array.
//
// Constraints
//
// - n == `nums.length`
// - 1 ≤ n ≤ 5 ∗ 10^4
// - -10^9 ≤ `nums[i]` ≤ 10^9

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P22_MajorityElement;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static int FindMajorityElement(int[] nums)
    {
        int count = 0;
        int majority = 0;

        // The other elements should not be able to drop the count to zero until the end since they are in minority.
        foreach (int num in nums)
        {
            if (count == 0 || majority == num)
            {
                majority = num;
                count++;
            }
            else
            {
                count--;
            }
        }

        return majority;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([0, 0, 1, 1, 1], 1);
        Run([1, 1, 1, 0, 0], 1);
        Run([1, 0, 1, 0, 1], 1);
    }

    private static void Run(int[] nums, int expectedResult)
    {
        int result = Solution.FindMajorityElement(nums);
        Utilities.PrintSolution(nums, result);
        Assert.AreEqual(expectedResult, result);
    }
}
