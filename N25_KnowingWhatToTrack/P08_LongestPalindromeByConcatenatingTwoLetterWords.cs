// Longest Palindrome by Concatenating Two-Letter Words
// ====================================================
//
// Suppose you are given an array of strings, `words`, and each element in the array has a length of two. You need to
// return the length of the longest palindrome that can be made by concatenating some elements from `words`. If no
// palindrome can be made, return 0.
//
// A palindrome is a sequence of characters that reads the same forward and backward.
//
// Constraints:
//
// - 1 ≤ `words.length` ≤ 10^6
// - `words[i].length` = 2
// - Each word can be used at most once.

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N25_KnowingWhatToTrack.P08_LongestPalindromeByConcatenatingTwoLetterWords;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(n).
    public static int LongestPalindrome(string[] words)
    {
        var counts = new Dictionary<string, int>();

        foreach (var word in words)
        {
            counts.TryAdd(word, 0);
            counts[word]++;
        }

        int length = 0;
        bool foundMid = false;
        foreach ((string word, int count) in counts)
        {
            if (word[0] < word[1])
            {
                var revWord = new string([word[1], word[0]]);
                if (counts.ContainsKey(revWord))
                {
                    length += 4 * Math.Min(count, counts[revWord]);
                }
            }
            else if (word[0] == word[1])
            {
                length += 4 * (count / 2);
                if (!foundMid && count % 2 != 0)
                {
                    foundMid = true;
                    length += 2;
                }
            }
        }

        return length;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(["xx", "xx", "xx", "yy", "yy", "yy", "xy", "xy", "yx"], 14);
    }

    private static void Run(string[] words, int expectedResult)
    {
        int result = Solution.LongestPalindrome(words);
        Utilities.PrintSolution(words, result);
        Assert.AreEqual(expectedResult, result);
    }
}
