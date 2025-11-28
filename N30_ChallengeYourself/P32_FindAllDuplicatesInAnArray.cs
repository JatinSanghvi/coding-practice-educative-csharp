// Find All Duplicates in an Array
// ===============================
//
// Given an integer array, `nums`, of length n, where all the integers of `nums` are in the range [1,n] and each integer
// appears once or twice, return an array of all the integers that appear twice.
//
// > Note: Write an algorithm that runs in O(n) time and uses only constant auxiliary space, excluding the space
// > occupied by the output.
//
// Constraints:
//
// - n= `nums.length`
// - 1 ≤ n ≤ 10^3
// - 1 ≤  `nums[i]` ≤ n
// - Each element in `nums` appears once or twice.

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P32_FindAllDuplicatesInAnArray;

public class Solution
{
    public static IList<int> FindDuplicates(int[] nums)
    {
        for (int i = 0; i != nums.Length; i++)
        {
            while (nums[i] != i + 1)
            {
                int j = nums[i] - 1;
                if (nums[i] == nums[j]) { break; }
                nums[i] = nums[j];
                nums[j] = j + 1;
            }
        }

        var duplicates = new List<int>();
        for (int i = 0; i != nums.Length; i++)
        {
            if (nums[i] != i + 1)
            {
                duplicates.Add(nums[i]);
            }
        }

        return duplicates;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 3, 4], []);
        Run([2, 2, 1, 1], [2, 1]);
        Run([4, 3, 3, 4], [4, 3]);
    }

    private static void Run(int[] nums, int[] expectedResult)
    {
        int[] numsCopy = nums.ToArray();
        int[] result = Solution.FindDuplicates(nums).ToArray();
        Utilities.PrintSolution(numsCopy, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
