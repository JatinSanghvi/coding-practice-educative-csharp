// Longest Happy String
// ====================
//
// A string is considered happy if it meets the following conditions:
//
// 1. It comprises only the characters `'a'`, `'b'`, and `'c'`.
// 2. It does not contain the substrings "aaa", "bbb", or "ccc".
// 3. The total occurrences of:
//    1. The character `'a'` does not exceed `a`.
//    2. The character `'b'` does not exceed `b`.
//    3. The character `'c'` does not exceed `c`.
//
// You are given three integers, `a`, `b`, and `c`, representing the maximum allowable occurrences of `'a'`, `'b'`, and
// `'c'`, respectively. Your task is to return the longest possible happy string. If there are multiple valid longest
// happy strings, return any one of them. If no such string can be formed, return an empty string "".
//
// Note: A substring is a contiguous sequence of characters within a string.
//
// Constraints:
//
// - 0 ≤ `a`, `b`, `c` ≤ 100
// - a + b + c > 0

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N07_Heaps.P09_LongestHappyString;

public class Solution
{
    // Time complexity: O(a+b+c), Space complexity: O(1).
    public string LongestDiverseString(int a, int b, int c)
    {
        // Using a simple approach, since the heap-based solution is far too complicated.
        a = Math.Min(a, 2 * (b + c + 1));
        b = Math.Min(b, 2 * (c + a + 1));
        c = Math.Min(c, 2 * (a + b + 1));

        var substring = new System.Text.StringBuilder();
        char last_char1 = 'x', last_char2 = 'x';
        while (a + b + c != 0)
        {
            char ch;
            if (last_char1 == 'a' && last_char2 == 'a')
            {
                ch = b >= c ? 'b' : 'c';
            }
            else if (last_char1 == 'b' && last_char2 == 'b')
            {
                ch = a >= c ? 'a' : 'c';
            }
            else if (last_char1 == 'c' && last_char2 == 'c')
            {
                ch = a >= b ? 'a' : 'b';
            }
            else
            {
                ch = a >= b && a >= c ? 'a' : b >= c ? 'b' : 'c';
            }

            substring.Append(ch);

            if (ch == 'a') { a--; }
            else if (ch == 'b') { b--; }
            else { c--; }

            (last_char1, last_char2) = (ch, last_char1);
        }

        return substring.ToString();
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(0, 0, 1, "c");
        Run(1, 9, 2, "bbcbbabbcbb");
    }

    private static void Run(int a, int b, int c, string expectedResult)
    {
        string result = new Solution().LongestDiverseString(a, b, c);
        Utilities.PrintSolution((a, b, c), result);
        Assert.AreEqual(expectedResult, result);
    }
}
