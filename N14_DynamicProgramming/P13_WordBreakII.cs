// Word Break II
// =============
//
// You are given a string, `s`, and an array of strings, `wordDict`, representing a dictionary. Your task is to add
// spaces to `s` to break it up into a sequence of valid words from `wordDict`. We are required to return an array of
// all possible sequences of words (sentences). The order in which the sentences are listed is not significant.
//
// > Note: The same dictionary word may be reused multiple times in the segmentation.
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 20
// - 1 ≤ `wordDict.length` ≤ 1000
// - 1 ≤ `wordDict[i].length` ≤ 10
// - `s` and `wordDict[i]` consist of only lowercase English letters.
// - All the strings of `wordDict` are unique.

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P13_WordBreakII;

public class Solution
{
    // Time complexity: O(100s + w * l), Space complexity: O(s^2).
    public static List<string> WordBreak(string s, List<string> wordDict)
    {
        var words = new HashSet<string>(wordDict);
        var starts = new List<int>[s.Length + 1];

        for (int end = 1; end != s.Length + 1; end++)
        {
            starts[end] = new List<int>();
            for (int start = end - 1; start != -1 && start != end - 11; start--)
            {
                string word = s[start..end];
                if (words.Contains(word))
                {
                    starts[end].Add(start);
                }
            }
        }

        return GetSentences(s.Length);

        List<string> GetSentences(int end)
        {
            var sentences = new List<string>();
            foreach (int start in starts[end])
            {
                string word = s[start..end];
                if (start == 0)
                {
                    sentences.Add(word);
                }
                else
                {
                    foreach (var prefix in GetSentences(start))
                    {
                        sentences.Add($"{prefix} {word}");
                    }
                }
            }

            return sentences;
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("abababab", ["ab", "ba", "aba", "bab"], ["ab ab ab ab", "aba bab ab", "aba ba bab", "ab aba bab"]);
    }

    private static void Run(string s, string[] wordDict, string[] expectedResult)
    {
        string[] result = Solution.WordBreak(s, wordDict.ToList()).ToArray();
        Utilities.PrintSolution((s, wordDict), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
