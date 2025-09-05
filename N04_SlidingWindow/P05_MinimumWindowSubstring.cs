// Minimum Window Substring
// ========================
//
// Given two strings, `s`, and `t`, find the minimum window substring in `s`, which has the following properties:
//
// 1. It is the shortest substring of `s` that includes all of the characters present in `t`.
// 2. It must contain at least the same frequency of each character as in `t`.
// 3. The order of the characters does not matter here.
//
// > Note: If there are multiple valid minimum window substrings, return any one of them.
//
// Constraints:
//
// - Strings `s` and `t` consist of uppercase and lowercase English characters.
// - 1 ≤ `s.length`, `t.length` ≤ 10^3

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N04_SlidingWindow.P05_MinimumWindowSubstring;

public class Solution
{
    public static string MinWindow(string s, string t)
    {
        // Count of character in t minus count of character in current s-window.
        var charCounts = new Dictionary<char, int>();

        foreach (char ch in t)
        {
            charCounts.TryAdd(ch, 0);
            charCounts[ch]++;
        }

        // Count of distinct characters in t that aren't entirely present in current s-window.
        int absentChars = charCounts.Count;
        string minWindow = string.Empty;

        int start = 0;
        for (int end = 0; end < s.Length; end++)
        {
            char ch = s[end];
            charCounts.TryAdd(ch, 0);
            charCounts[ch]--;

            if (charCounts[ch] == 0)
            {
                absentChars--;
            }

            while (absentChars == 0)
            {
                ch = s[start];
                charCounts[ch]++;

                if (charCounts[ch] == 1)
                {
                    absentChars++;

                    if (string.IsNullOrEmpty(minWindow) || minWindow.Length > end - start + 1)
                    {
                        minWindow = s[start..(end + 1)];
                    }
                }

                start++;
            }
        }

        return minWindow;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("abaaacaabaca", "cb", "bac");
    }

    private static void Run(string s, string t, string expectedResult)
    {
        string result = Solution.MinWindow(s, t);
        Utilities.PrintSolution((s, t), result);
        Assert.AreEqual(expectedResult, result);
    }
}
