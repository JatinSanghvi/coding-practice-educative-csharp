// Find the Corrupt Pair
// =====================
//
// We are given an unsorted array, `nums`, with n elements and each element is in the range [1, n] inclusive. The array
// originally contained all the elements from 1 to n but due to a data error, one of the numbers is duplicated, which
// causes another number missing. Find and return the corrupt pair (missing, duplicated).
//
// Constraints:
//
// - 2 ≤ n ≤ 10^3
// - 1 ≤ `nums[i]` ≤ n

using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N15_CyclicSort.P04_FindTheCorruptPair;

public class Solution
{
    public static int[] FindCorruptPair(int[] nums)
    {
        int i = 0;
        while (i != nums.Length)
        {
            int j = nums[i] - 1;
            if (nums[i] != nums[j])
            {
                (nums[i], nums[j]) = (nums[j], nums[i]);
            }
            else
            {
                i++;
            }
        }

        for (i = 0; i != nums.Length; i++)
        {
            if (nums[i] != i + 1)
            {
                return new int[] { i + 1, nums[i] };
            }
        }

        throw new ArgumentException();
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([3, 2, 1, 2], [4, 2]);
        Run([2, 3, 4, 3], [1, 3]);
    }

    private static void Run(int[] nums, int[] expectedResult)
    {
        int[] numsCopy = nums.ToArray();
        int[] result = Solution.FindCorruptPair(nums);
        Utilities.PrintSolution(numsCopy, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
