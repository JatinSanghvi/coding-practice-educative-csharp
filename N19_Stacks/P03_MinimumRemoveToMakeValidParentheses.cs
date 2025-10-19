// Minimum Remove to Make Valid Parentheses
// ========================================
//
// Given a string, `s`, that may have matched and unmatched parentheses, remove the minimum number of parentheses so
// that the resulting string represents a valid parenthesization. For example, the string "a(b)" represents a valid
// parenthesization while the string "a(b" doesn't, since the opening parenthesis doesn't have any corresponding closing
// parenthesis.
//
// Constraints:
//
// - 1 ≤ `s.length` ≤ 10^3
// - `s[i]` is either an opening parenthesis '(', a closing parenthesis ')', or a lowercase English letter.

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N19_Stacks.P03_MinimumRemoveToMakeValidParentheses;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(n).
    public static string MinRemoveParentheses(string s)
    {
        char[] chars = s.ToCharArray();

        int count = 0;
        for (int i = 0; i != chars.Length; i++)
        {
            if (chars[i] == '(')
            {
                count++;
            }
            else if (chars[i] == ')')
            {
                if (count == 0) { chars[i] = ' '; }
                else { count--; }
            }
        }

        count = 0;
        for (int i = chars.Length - 1; i != -1; i--)
        {
            if (chars[i] == ')')
            {
                count++;
            }
            else if (chars[i] == '(')
            {
                if (count == 0) { chars[i] = ' '; }
                else { count--; }
            }
        }

        return new string(chars.Where(ch => ch != ' ').ToArray());
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run("(a(b))()c)d", "(a(b))()cd");
        Run("a(b()((c)d)", "ab()((c)d)");
    }

    private static void Run(string s, string expectedResult)
    {
        string result = Solution.MinRemoveParentheses(s);
        Utilities.PrintSolution(s, result);
        Assert.AreEqual(expectedResult, result);
    }
}
