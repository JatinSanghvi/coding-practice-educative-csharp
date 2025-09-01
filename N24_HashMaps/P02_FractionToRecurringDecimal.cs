// Fraction to Recurring Decimal
// =============================
//
// Given the two integer values of a fraction, `numerator` and `denominator`, implement a function that returns the
// fraction in string format. If the fractional part repeats, enclose the repeating part in parentheses.
//
// Constraints:
//
// - `denominator` != 0
// - -2^31 ≤ `numerator`, `denominator` ≤ 2^31 - 1

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P02_FractionToRecurringDecimal;

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
