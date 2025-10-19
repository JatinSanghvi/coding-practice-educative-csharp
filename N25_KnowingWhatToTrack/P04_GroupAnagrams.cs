// Group Anagrams
// ==============
//
// Given a list of words or phrases, group the words that are anagrams of each other. An anagram is a word or phrase
// formed from another word by rearranging its letters.
//
// Constraints:
//
// - 1 ≤ `strs.length` ≤ 10^3
// - 0 ≤ `strs[i].length` ≤ 100
// - `strs[i]` consists of lowercase English letters.
//
// > Note: The order in which the output is displayed doesn't matter.

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N25_KnowingWhatToTrack.P04_GroupAnagrams;

public class Solution
{
    private static Dictionary<char, int> primes = new()
    {
        ['a'] = 2, ['b'] = 3, ['c'] = 5, ['d'] = 7, ['e'] = 11, ['f'] = 13, ['g'] = 17, ['h'] = 19, ['i'] = 23,
        ['j'] = 29, ['k'] = 31, ['l'] = 37, ['m'] = 41, ['n'] = 43, ['o'] = 47, ['p'] = 53, ['q'] = 59, ['r'] = 61,
        ['s'] = 67, ['t'] = 71, ['u'] = 73, ['v'] = 79, ['w'] = 83, ['x'] = 89, ['y'] = 97, ['z'] = 101,
    };

    // Time complexity: O(n*l), Space complexity: O(n*l) where l = average string length;
    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var groups = new Dictionary<int, IList<string>>();

        foreach (string str in strs)
        {
            int hash = 1;
            foreach (char letter in str)
            {
                hash *= primes[letter];
            }

            groups.TryAdd(hash, new List<string>());
            groups[hash].Add(str);
        }

        return groups.Values.ToList();
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(["abb", "bab", "ba", "bba", "ab", ""], [["abb", "bab", "bba"], ["ba", "ab"], [""]]);
    }

    private static void Run(string[] strs, string[][] expectedResult)
    {
        string[][] result = Solution.GroupAnagrams(strs).Select(group => group.ToArray()).ToArray();
        Utilities.PrintSolution(strs, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
