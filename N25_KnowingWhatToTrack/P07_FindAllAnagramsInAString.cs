// Find All Anagrams in a String
// =============================
//
// Given two strings, `a` and `b`, return an array of all the start indexes of anagrams of `b` in `a`. We may return the
// answer in any order.
//
// > An anagram is a word or phrase created by rearranging the letters of another word or phrase while utilizing each of
// > the original letters exactly once. For example, "act" is the anagram of "cat", and "flow" is the anagram of "wolf".
//
// Constraints:
//
// - 1 ≤ `a.length`, `b.length` ≤ 3 × 10^3
// - Both `a` and `b` consist only of lowercase English letters.

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N25_KnowingWhatToTrack.P07_FindAllAnagramsInAString;

public class Solution
{
    // Time complexity: O(a+b), Space complexity: O(1).
    public static IList<int> FindAnagrams(string a, string b)
    {
        var bCounts = new int[26]; // Per-char counts in string b.
        int bLetters = 0; // Unique char count in string b.

        foreach (char ch in b)
        {
            int i = ch - 'a';
            bCounts[i]++;
            if (bCounts[i] == 1) { bLetters++; }
        }

        var aCounts = new int[26]; // Per-char counts in string a.
        int aLetters = 0; // Unique char count in string a.
        int abLetters = 0; // Count of chars with equal counts in strings a and b.

        var indexes = new List<int>();

        for (int index = 0; index != a.Length; index++)
        {
            int i;

            if (index >= b.Length)
            {
                i = a[index - b.Length] - 'a';
                if (aCounts[i] == bCounts[i]) { abLetters--; }

                aCounts[i]--;
                if (aCounts[i] == bCounts[i]) { abLetters++; }
                if (aCounts[i] == 0) { aLetters--; }
            }

            i = a[index] - 'a';
            if (aCounts[i] == bCounts[i]) { abLetters--; }

            aCounts[i]++;
            if (aCounts[i] == bCounts[i]) { abLetters++; }
            if (aCounts[i] == 1) { aLetters++; }

            if (
                aLetters == abLetters /* All a letters are in b */ &&
                bLetters == abLetters /* All b letters are in a */)
            {
                indexes.Add(index - b.Length + 1);
            }
        }

        return indexes;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("abbaabba", "abb", [0, 1, 4, 5]);
    }

    private static void Run(string a, string b, int[] expectedResult)
    {
        int[] result = Solution.FindAnagrams(a, b).ToArray();
        Utilities.PrintSolution((a, b), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
