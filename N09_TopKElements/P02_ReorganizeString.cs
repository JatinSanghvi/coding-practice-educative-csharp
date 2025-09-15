// Reorganize String
// =================
//
// Given a string, `str`, rearrange it so that any two adjacent characters are not the same. If such a reorganization of
// the characters is possible, output any possible valid arrangement. Otherwise, return an empty string.
//
// Constraints:
//
// - 1 ≤ `str.length` ≤ 500
// - Input string consists of lowercase English letters.

using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P02_ReorganizeString;

public class Solution
{
    // Time complexity: O(n) since `count` and `frequencyHeap` will have maximum size of 26, Space complexity: O(1).
    public static string ReorganizeString(string string1)
    {
        var counts = new Dictionary<char, int>();
        foreach (char ch in string1)
        {
            counts.TryAdd(ch, 0);
            counts[ch]++;
        }

        var frequencyHeap = new PriorityQueue<char, int>();
        foreach (KeyValuePair<char, int> pair in counts)
        {
            frequencyHeap.Enqueue(pair.Key, -pair.Value);
        }

        var result = new StringBuilder();
        char lastChar = '\0';
        while (frequencyHeap.TryDequeue(out char ch, out int negFrequency))
        {
            if (ch == lastChar)
            {
                if (!frequencyHeap.TryDequeue(out char ch2, out int negFrequency2))
                {
                    return string.Empty;
                }

                UpdateStringAndHeap(ch2, negFrequency2);
            }

            UpdateStringAndHeap(ch, negFrequency);
            lastChar = ch;
        }

        return result.ToString();

        void UpdateStringAndHeap(char ch, int negFrequency)
        {
            result.Append(ch);
            if (negFrequency != -1)
            {
                frequencyHeap.Enqueue(ch, negFrequency + 1);
            }
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("bbaaaaacc", "acabacaba");
        Run("baaaac", "");
    }

    private static void Run(string string1, string expectedResult)
    {
        string result = Solution.ReorganizeString(string1);
        Utilities.PrintSolution(string1, result);
        Assert.AreEqual(expectedResult, result);
    }
}
