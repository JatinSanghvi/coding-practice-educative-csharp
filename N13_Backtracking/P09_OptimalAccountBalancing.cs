// Optimal Account Balancing
// =========================
//
// Given a list of transactions, where each transaction is represented as `transactions[i] = [from_i, to_i, amount_i]`,
// indicating that the person `from_i` gave `amount_i` to the person `to_i`. Return the minimum number of transactions
// needed to settle all debts.
//
// Constraints:
//
// - 1 ≤ `transactions.length` ≤ 10
// - `transactions[i].length` == 3
// - 0 ≤ `from_i`, `to_i` ≤ 10
// - 1 ≤ `amount_i` ≤ 100
// - `from_i` ≠ `to_i`

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N13_Backtracking.P09_OptimalAccountBalancing;

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
