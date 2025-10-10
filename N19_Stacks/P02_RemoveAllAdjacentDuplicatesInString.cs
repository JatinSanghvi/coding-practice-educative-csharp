// Remove All Adjacent Duplicates In String
// ========================================
//
// You are given a string consisting of lowercase English letters. Repeatedly remove adjacent duplicate letters, one
// pair at a time. Both members of a pair of adjacent duplicate letters need to be removed.
//
// Constraints:
//
// - 1 ≤ `string.length` ≤ 10^3
// - `string` consists of lowercase English alphabets.

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N19_Stacks.P02_RemoveAllAdjacentDuplicatesInString;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(n).
    public static string RemoveDuplicates(string str)
    {
        var stack = new Stack<char>();

        foreach (char ch in str)
        {
            if (stack.Count != 0 && stack.Peek() == ch)
            {
                stack.Pop();
            }
            else
            {
                stack.Push(ch);
            }
        }

        return new string(stack.Reverse().ToArray());
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("abbccbab", "abab");
    }

    private static void Run(string str, string expectedResult)
    {
        string result = Solution.RemoveDuplicates(str);
        Utilities.PrintSolution(str, result);
        Assert.AreEqual(expectedResult, result);
    }
}
