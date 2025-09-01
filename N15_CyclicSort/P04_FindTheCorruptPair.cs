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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N15_CyclicSort.P04_FindTheCorruptPair;

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
