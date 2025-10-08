// Cyclic Sort
// ===========
//
// You are given an integer array, `nums` of size n, where each number is distinct and falls within the range [1, n].
// Your task is to sort the array in place while ensuring a time complexity of O(n) and using only O(1) extra space.
//
// Constraints:
//
// - n == `nums.length`
// - 1 ≤ n ≤ 10^3
// - Each element in `nums` is unique and within the range [1, n].

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N15_CyclicSort.P01_CyclicSort;

public class Solution
{
    public int[] CyclicSort(int[] nums)
    {
        for (int i = 0; i != nums.Length; i++)
        {
            while (nums[i] != i + 1)
            {
                int j = nums[i] - 1;
                (nums[i], nums[j]) = (nums[j], nums[i]);
            }
        }

        return nums;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([4, 3, 2, 1], [1, 2, 3, 4]);
    }

    private static void Run(int[] nums, int[] expectedResult)
    {
        int[] numsCopy = nums.ToArray();
        int[] result = new Solution().CyclicSort(nums);
        Utilities.PrintSolution(numsCopy, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
