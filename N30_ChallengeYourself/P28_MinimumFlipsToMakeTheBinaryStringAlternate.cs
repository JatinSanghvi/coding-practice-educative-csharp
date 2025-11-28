// Minimum Flips to Make the Binary String Alternate
// =================================================
//
// Given a binary string `s`, the following two operations can be performed in any sequence:
//
// - Type--1: Remove the character at the start of the string `s` and append it to the end of the string.
//
// - Type--2: Pick any character from the string and flip its value. in other words, if its value is 0, it becomes 1 and
//   vice versa.
//
// Your task is to return the minimum number of type-2 operations that you need to perform before `s` becomes
// alternating.
//
// > Note: The string is called alternating if no two adjacent characters are equal.
//
// Constraints:
//
// - 1≤ `s.length` ≤105
// - `s[i]` is either 0 or 1.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P28_MinimumFlipsToMakeTheBinaryStringAlternate;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(n).
    public static int MinFlips(string s)
    {
        int len = s.Length;
        var bits = new List<bool>();
        bits.AddRange(s.Select(ch => ch == '1'));
        bits.AddRange(s.Select(ch => ch == '1'));

        int flips = 0;
        int minFlips = int.MaxValue;
        for (int i = 0; i != 2 * len; i++)
        {
            flips += ((i % 2 == 0) == bits[i]) ? 1 : 0;

            if (i >= len)
            {
                flips -= (((i - len) % 2 == 0) == bits[i - len]) ? 1 : 0;
            }

            if (i >= len - 1)
            {
                minFlips = Math.Min(minFlips, flips);
                minFlips = Math.Min(minFlips, len - flips);
            }
        }

        return minFlips;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("111000", 2);
        Run("1111000", 2);
    }

    private static void Run(string s, int expectedResult)
    {
        int result = Solution.MinFlips(s);
        Utilities.PrintSolution(s, result);
        Assert.AreEqual(expectedResult, result);
    }
}
