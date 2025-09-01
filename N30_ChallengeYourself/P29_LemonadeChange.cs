// Lemonade Change
// ===============
//
// There is a lemonade stand where customers can buy one lemonade at a time for $5 and pay with a $5, $10, or $20 bill.
// It is necessary to return the correct change to each customer so that the net transaction is completed successfully
// with a total payment of $5. Note that no change is available initially.
//
// Given an integer array, `bills`, where `bills[i]` represents the bill paid by the ith customer, return TRUE if it is
// possible to provide every customer with the correct change, or FALSE otherwise.
//
// Constraints:
//
// - 1≤ `bills.length` ≤500
//
// - `bills[i]` is either 5, 10, or 20.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P29_LemonadeChange;

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
