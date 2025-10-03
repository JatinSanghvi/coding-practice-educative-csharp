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

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N13_Backtracking.P09_OptimalAccountBalancing;

public class Solution
{
    // Time complexity: O((n/2)!), Space complexity: O(n).
    public int MinTransfers(int[][] transactions)
    {
        var balances = new Dictionary<int, int>();
        foreach (int[] transaction in transactions)
        {
            (int p1, int p2, int amount) = (transaction[0], transaction[1], transaction[2]);

            balances.TryAdd(p1, 0);
            balances.TryAdd(p2, 0);
            balances[p1] -= amount;
            balances[p2] += amount;
        }

        var lenders = balances.Select(b => -b.Value).Where(b => b > 0).ToArray();
        var borrowers = balances.Select(b => b.Value).Where(b => b > 0).ToArray();

        return Solve(0);

        int Solve(int l)
        {
            if (l == lenders.Length)
            {
                return 0;
            }

            int minTransfers = int.MaxValue;

            for (int b = 0; b != borrowers.Length; b++)
            {
                if (borrowers[b] != 0)
                {
                    int amount = Math.Min(lenders[l], borrowers[b]);
                    lenders[l] -= amount;
                    borrowers[b] -= amount;

                    minTransfers = Math.Min(minTransfers, Solve(lenders[l] > 0 ? l : l + 1) + 1);

                    lenders[l] += amount;
                    borrowers[b] += amount;
                }
            }

            return minTransfers;
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[0, 1, 10], [1, 2, 20], [2, 3, 10], [3, 0, 20]], 2);
        Run([[0, 1, 10], [1, 2, 20], [2, 3, 30], [3, 0, 40]], 3);
    }

    private static void Run(int[][] transactions, int expectedResult)
    {
        int result = new Solution().MinTransfers(transactions);
        Utilities.PrintSolution(transactions, result);
        Assert.AreEqual(expectedResult, result);
    }
}
