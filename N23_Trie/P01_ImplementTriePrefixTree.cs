// Implement Trie (Prefix Tree)
// ============================
//
// Trie is a tree-like data structure used to store strings. The tries are also called prefix trees because they provide
// very efficient prefix-matching operations. Implement a [trie](https://www.educative.io/answers/what-is-a-prefix-tree)
// data structure with three functions that perform the following tasks:
//
// - Insert (word): This inserts a word into the trie.
// - Search (word): This searches the given word in the trie and returns TRUE, if found. Otherwise, return FALSE.
// - Search prefix (prefix): This searches the given prefix in the trie and returns TRUE, if found. Otherwise, return
//   FALSE.
//
// Constraints:
//
// - 1 ≤ `word.length`, `prefix.length` ≤ 500
// - The strings consist only of lowercase English letters.
// - At most, 10^3 calls in total will be made to the functions.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N23_Trie.P01_ImplementTriePrefixTree;

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
