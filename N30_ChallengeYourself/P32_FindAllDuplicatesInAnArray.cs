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
//
// - 1≤n≤103
//
// - 1≤ `nums[i]` ≤n
//
// - Each element in `nums` appears once or twice.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P32_FindAllDuplicatesInAnArray;

public class Solution
{
    public static bool Function()
    {
        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(true);
    }

    private static void Run(bool expectedResult)
    {
        bool result = Solution.Function();
        Utilities.PrintSolution(true, result);
        Assert.AreEqual(expectedResult, result);
    }
}
