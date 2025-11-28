// Multiply Strings
// ================
//
// Given two non-negative integers, `str1` and `str2`, represented as strings, return the product of these integers,
// `result`, which is also represented as strings.
//
// Constraints:
//
// - `str1` and `str2` consist of digits only.
// - 1 ≤ `str1.length`, `str2.length` ≤ 200
// - No leading 0 in `str1` or `str2`

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P39_MultiplyStrings;

public class Solution
{
    // Time complexity: O(mn), Space complexity: O(m+n).
    public static string MultiplyStrings(string str1, string str2)
    {
        if (str1 == "0" || str2 == "0") { return "0"; }

        var stack = new Stack<char>();
        int sum = 0;
        for (int place = 0; place != str1.Length + str2.Length; place++)
        {
            for (int i1 = str1.Length - 1, i2 = str2.Length - 1 - place; i1 >= 0 && i2 <= str2.Length - 1; i1--, i2++)
            {
                if (i2 < 0) { continue; }
                sum += (str1[i1] - '0') * (str2[i2] - '0');
            }

            stack.Push((char)('0' + sum % 10));
            sum /= 10;
        }

        return new string(stack.ToArray()).TrimStart('0');
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("10", "10", "100");
        Run("1111111111", "1111111111", "1234567900987654321");
    }

    private static void Run(string str1, string str2, string expectedResult)
    {
        string result = Solution.MultiplyStrings(str1, str2);
        Utilities.PrintSolution((str1, str2), result);
        Assert.AreEqual(expectedResult, result);
    }
}
