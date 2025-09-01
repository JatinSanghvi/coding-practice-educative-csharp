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
    public static bool Function()
    {
        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(true);
    }

    private static void Run(bool expectedResult)
    {
        bool result = Solution.Function();
        Utilities.PrintSolution(true, result);
        Assert.AreEqual(expectedResult, result);
    }
}
