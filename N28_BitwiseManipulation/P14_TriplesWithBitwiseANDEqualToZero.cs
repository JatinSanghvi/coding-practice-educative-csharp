// Triples with Bitwise AND Equal To Zero
// ======================================
//
// You're given an array of integers called `nums`. Your task is to count how many triplets of indexes (`i`, `j`, `k`)
// satisfy the condition `nums[i] & nums[j] & nums[k] == 0`, where `&` is the bitwise AND operator and 0 ≤ `i`, `j`, `k`
// ≤ `nums.length`.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 1000
// - 0 ≤ `nums[i]` ≤ 2^10

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N28_BitwiseManipulation.P14_TriplesWithBitwiseANDEqualToZero;

public class Solution
{
    // Time complexity: O(n^2), Space complexity: O(1024).
    public int CountTriplets(int[] nums)
    {
        var andCounts = new int[1025];

        foreach (int num1 in nums)
        {
            foreach (int num2 in nums)
            {
                andCounts[num1 & num2]++;
            }
        }

        int triplets = 0;
        foreach (int num1 in nums)
        {
            for (int num2 = 0; num2 != 1025; num2++)
            {
                if ((num1 & num2) == 0)
                {
                    triplets += andCounts[num2];
                }
            }
        }

        return triplets;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([0], 1);
        Run([3, 5, 6], 6);
        Run([1, 2, 4], 24);
    }

    private static void Run(int[] nums, int expectedResult)
    {
        int result = new Solution().CountTriplets(nums);
        Utilities.PrintSolution(nums, result);
        Assert.AreEqual(expectedResult, result);
    }
}
