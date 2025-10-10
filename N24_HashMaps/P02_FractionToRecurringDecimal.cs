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

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P02_FractionToRecurringDecimal;

public class Solution
{
    // Time complexity: O(den / gcd(num,den)), Space complexity: O(den / gcd(num,den)).
    public static string FractionToDecimal(int numerator, int denominator)
    {
        string result = numerator == 0 || (numerator > 0) == (denominator > 0) ? "" : "-";

        numerator = Math.Abs(numerator);
        denominator = Math.Abs(denominator);

        (int integer, int remainder) = Math.DivRem(numerator, denominator);
        result += integer;

        if (remainder != 0)
        {
            string decimals = "";
            var positions = new Dictionary<int, int>();
            int position = 0;
            while (remainder != 0 && !positions.ContainsKey(remainder))
            {
                positions[remainder] = position;
                (int digit, remainder) = Math.DivRem(remainder * 10, denominator);
                decimals += digit;
                position++;
            }

            if (remainder == 0)
            {
                result += "." + decimals;
            }
            else
            {
                result += "." + decimals[..positions[remainder]] + "(" + decimals[positions[remainder]..] + ")";
            }
        }

        return result;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(125, 80, "1.5625");
        Run(-25, 70, "-0.3(571428)");
    }

    private static void Run(int numerator, int denominator, string expectedResult)
    {
        string result = Solution.FractionToDecimal(numerator, denominator);
        Utilities.PrintSolution((numerator, denominator), result);
        Assert.AreEqual(expectedResult, result);
    }
}
