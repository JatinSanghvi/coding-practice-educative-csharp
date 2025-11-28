// Add Binary
// ==========
//
// Given two binary strings `str1` and `str2`, return their sum as a binary string.
//
// Constraints:
//
// - 1 ≤ `str1.length` , `str2.length` ≤ 500
// - `str1` and `str2` consist of `0` or `1` characters only.
// - Any string must not contain leading zeros except the string representing the binary form of 0.

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P38_AddBinary;

public class Solution
{
    // Time complexity: O(m+n), Space complexity: O(m+n).
    public static string AddBinary(string str1, string str2)
    {
        var stack = new Stack<int>();
        int carry = 0;
        for (int i1 = str1.Length - 1, i2 = str2.Length - 1; i1 >= 0 || i2 >= 0; i1--, i2--)
        {
            int bit1 = i1 >= 0 && str1[i1] == '1' ? 1 : 0;
            int bit2 = i2 >= 0 && str2[i2] == '1' ? 1 : 0;

            int sum = bit1 + bit2 + carry;
            stack.Push(sum % 2);
            carry = sum / 2;
        }

        if (carry != 0)
        {
            stack.Push(carry);
        }

        return new string(stack.Select(num => num == 0 ? '0' : '1').ToArray());
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("1010", "110", "10000");
        Run("0", "0", "0");
    }

    private static void Run(string str1, string str2, string expectedResult)
    {
        string result = Solution.AddBinary(str1, str2);
        Utilities.PrintSolution((str1, str2), result);
        Assert.AreEqual(expectedResult, result);
    }
}
