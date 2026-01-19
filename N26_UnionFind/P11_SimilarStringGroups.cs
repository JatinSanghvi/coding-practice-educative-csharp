// Similar String Groups
// =====================
//
// Two strings `x` and `y` are considered *similar* if they are either exactly the same or can be made identical by
// swapping at most two different characters in string `x`.
//
// We define a *similarity group* as a set of strings where each string is similar to at least one other string in the
// group. A string doesn't need to be directly similar to every other string in the group --- it just needs to be
// connected to them through a chain of similarities.
//
// Given a list of strings `strs`, where each string is an anagram of the others, your task is to determine how many
// such similarity groups exist in the list.
//
// Constraints:
//
// - 1 ≤ `strs.length` ≤ 300
// - 1 ≤ `strs[i].length` ≤ 300
// - `strs[i]` consists of lowercase letters only.
// - All words in `strs` have the same length and are anagrams of each other.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N26_UnionFind.P11_SimilarStringGroups;

public class Solution
{
    // Time complexity: O(n^2*len), Space complexity: O(n).
    public static int NumSimilarGroups(string[] strs)
    {
        int n = strs.Length;
        int len = strs[0].Length;

        var parents = new int[n];
        var ranks = new int[n];
        int groups = n;

        for (int i = 0; i != n; i++)
        {
            parents[i] = i;
        }

        for (int i = 0; i != n; i++)
        {
            for (int j = i + 1; j != n; j++)
            {
                int diffs = 0;
                for (int k = 0; k != len; k++)
                {
                    diffs += strs[i][k] != strs[j][k] ? 1 : 0;
                }

                if (diffs <= 2) { Union(i, j); }
            }
        }

        return groups;

        void Union(int x1, int x2)
        {
            int p1 = Find(x1);
            int p2 = Find(x2);

            if (p1 == p2) { return; }

            if (ranks[p1] == ranks[p2]) { ranks[p1]++; }
            if (ranks[p1] >= ranks[p2]) { parents[p2] = p1; }
            else { parents[p1] = p2; }
            groups--;
        }

        int Find(int x)
        {
            if (parents[x] != x) { parents[x] = Find(parents[x]); }
            return parents[x];
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(["abbc", "abbc", "abcb"], 1);
        Run(["abbc", "acbb", "bacb", "bbca"], 2);
        Run(["abbc", "acbb", "bacb", "bbca", "cbba"], 1);
    }

    private static void Run(string[] strs, int expectedResult)
    {
        int result = Solution.NumSimilarGroups(strs);
        Utilities.PrintSolution(strs, result);
        Assert.AreEqual(expectedResult, result);
    }
}
