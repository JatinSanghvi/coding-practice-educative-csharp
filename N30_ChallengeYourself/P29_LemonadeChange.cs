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
// - 1 ≤ `bills.length` ≤ 500
// - `bills[i]` is either 5, 10, or 20.

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P29_LemonadeChange;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static bool LemonadeChange(int[] bills)
    {
        int count5 = 0, count10 = 0, count20 = 0;

        foreach (int bill in bills)
        {
            if (bill == 5)
            {
                count5++;
            }
            else if (bill == 10)
            {
                if (count5 >= 1) { count5--; }
                else { return false; }
                count10++;
            }
            else
            {
                if (count10 >= 1 && count5 >= 1) { count5--; count10--; }
                else if (count5 >= 3) { count5 -= 3; }
                else { return false; }
                count20++;
            }
        }

        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([5, 10, 10, 5, 5, 20], false);
        Run([5, 5, 10, 10, 20, 5], false);
        Run([5, 5, 20, 10, 10, 5], false);
        Run([5, 5, 5, 20, 10, 10], false);
        Run([5, 10, 5, 20, 5, 10], true);
    }

    private static void Run(int[] bills, bool expectedResult)
    {
        bool result = Solution.LemonadeChange(bills);
        Utilities.PrintSolution(bills, result);
        Assert.AreEqual(expectedResult, result);
    }
}
