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
